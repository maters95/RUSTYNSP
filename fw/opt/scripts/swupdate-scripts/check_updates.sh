#!/bin/bash
#
# check-updates.sh: wrapper script around swupdate
#
# Arguments:
# -delay   sleep for a random delay before starting the download of
#          new image (to prevent thousands of units starting the
#          download at the same time).
#          use this when calling from cron or after boot.
# -check   (only) check if there is a new version available.
# -update  check and, when necessary, update.
# -force   force downloading and installing the new image, even if its
#          version is older or same as already installed version.
# -offline search for updates on removable storage devices
#
# Behaviour when called without any arguments is same as -update
#
#
# RESUME DOWNLOAD DETAILS
# swupdate can retry and resume a broken download. See -t and -r arguments
# in do_swupdate call at end of this file.
#
# Implementation in swupdate:
# https://github.com/sbabic/swupdate/blob/master/corelib/downloader.c
#
# Note that it only resumes the download when kept running: after the
# swupdate process has stopped, for example because of a reboot, it will
# restart. Improving this, without adding an intermediate scratchpad on disk,
# is not straightforward: the download is streamed straight into ubifs on the
# CCGX, and re-opening an unfinished ubifs volume is not a good idea.
#
# Resuming while online file has changed:
# When a new version is made available, the var-swu-image-[machine].swu file on
# the webserver is replaced with the newer one. Devices busy starting a
# resume after that should not accidentally resume the download with the new
# file. A waste of bandwidth and possible leads to installing and booting
# into a corrupt rootfs. (What type of CRC or hash does swupdate on the swu
# file after download?)
#
# This is prevented this by dowloading the file that contains its version
# in the name. Therefore the webserver should always have the latest file
# available under two names:
# var-swu-image-[machine].swu
# var-swu-image-[machine]-[build-date-time].swu
#
# Best sequence of installing the files on the webserver is:
# 1. var-swu-image-[machine]-[build-date-time].swu
# 2. var-swu-image-[machine].swu
# 3. rename or remove the old build-date-time file: force the running
#    downloads to cancel.

. $(dirname $0)/functions.sh

get_swu_version() {
    if [ -f "$1" ]; then
        # local file
        cmd="head -n 10"
        $cmd "$1" | sed -n '/version/ s/[^"]*"\([^"]*\).*/\1/p'
    else
        # url, probably
        cmd="curl -s -r 0-999 -m 30 --retry 3"
        $cmd "$1" | cpio --quiet -i --to-stdout sw-description 2>/dev/null | sed -n '/version/ s/[^"]*"\([^"]*\).*/\1/p'
    fi
}

swu_status() {
    printf '%s\n' "$1" ${offline:+""} "$2" >$status_file
}

decrypt_swu() {
      local f="$1"
      echo "$f will be decrypted" >>/opt/applications/SoftwareUpgrade.log
      SWU="${f}.swu"
      systemctl stop watchdog-launcher
      echo "Gui application stopped" >>/opt/applications/SoftwareUpgrade.log
      sync
      cd /opt/applications/gui/
      ./software_update_static &
      cd -
      sync
      echo "Starting openssl at $(date +%T)" >>/opt/applications/SoftwareUpgrade.log
      openssl  aes-128-cbc -d  -md md5 -a -in "$f" -out "$SWU" -kfile /opt/applications/scripts/swupdate-scripts/password
      wait -f
      sync
      echo "Openssl Completed at $(date +%T)" >>/opt/applications/SoftwareUpgrade.log
     if [ -f "$SWU" ]; then
        echo "Deccrypted file $SWU" >>/opt/applications/SoftwareUpgrade.log
        rm -f "$f"  &&   echo "Encrypted file $f deleted" >>/opt/applications/SoftwareUpgrade.log || echo "Encrypted file $f NOT deleted" >>/opt/applications/SoftwareUpgrade.log
      else
        echo "No decrypted file $SWU" >>/opt/applications/SoftwareUpgrade.log
        SWU="NoFile"
      fi
}

# backup_conf() {
# Back up the /opt/applications/conf folder to /mnt/usb/upgrade/conf_backup.tgz
    # tar -czf /mnt/usb/upgrade/conf_backup.tgz -C /opt/applications/conf .
# }

# restore_conf() {
# Restores the /opt/applications/conf folder from /mnt/usb/upgrade/conf.tgz
    # tar -xzf /mnt/usb/upgrade/conf_backup.tgz -C /opt/applications/conf
# }

KERNEL_BOOT_ARGS_FILE=/dev/mtd1
REDUND_KERNEL_BOOT_ARGS_FILE=/dev/mtd2
TEMP_FILE=/tmp/boot_args_check
LOG_FILE=/opt/applications/gui/HaltechQt.log

echo "Running bootargs integrity check..."

# read the CRC of kernel boot args
od -N 4 -j 4 -i $KERNEL_BOOT_ARGS_FILE | awk '{print $2}' > $TEMP_FILE
read boot_args_crc < $TEMP_FILE

# read the CRC of redundant kernel boot args
od -N 4 -j 4 -i $REDUND_KERNEL_BOOT_ARGS_FILE | awk '{print $2}' > $TEMP_FILE
read redundant_boot_args_crc < $TEMP_FILE

echo -e "boot_args_crc:$boot_args_crc\tredundant_boot_args_crc:$redundant_boot_args_crc"

# compare the crc and do the following if they are not equal
if [ "$boot_args_crc" -ne "$redundant_boot_args_crc" ]; then
        echo "CRC Mismatch... taking corrective action"

        # calculate CRC for the kernel_boot_args
        # extracting the payload
        od -N 4 -j 0 -i $KERNEL_BOOT_ARGS_FILE | awk '{print $2}' > $TEMP_FILE
        read kernel_boot_args_len < $TEMP_FILE

        if [ $kernel_boot_args_len -lt 0 ] || [ $kernel_boot_args_len -gt 2048 ]; then
                kernel_boot_args_len=0
        fi


        # extract the payload into a temp file
        dd if=$KERNEL_BOOT_ARGS_FILE of=$TEMP_FILE bs=2048 skip=8 count=$kernel_boot_args_len iflag=skip_bytes,count_bytes iflag=skip_bytes,count_bytes &> /d

        # calculate the CRC
        calcCrcHex=$(crc32 $TEMP_FILE)
        calcCrc=$(echo $((16#$calcCrcHex)))


        # verify the crc
        # if verification succeeds copy the page 1 to redundant page
        # else copy redundant page to kernel_boot_args page

        if [ "$calcCrc" -eq "$boot_args_crc" ]; then
                echo "redundant_boot_args is corrupted... Copying the boot_args to redundant_boot_args "
                flash_erase $REDUND_KERNEL_BOOT_ARGS_FILE 0 0 &> /dev/null
                dd if=$KERNEL_BOOT_ARGS_FILE of=$TEMP_FILE bs=2048 count=1 &> /dev/null
                nandwrite -p $REDUND_KERNEL_BOOT_ARGS_FILE $TEMP_FILE &> /dev/null
        else
                echo "boot_args is corrupted... Copying the redundant_boot_args to boot_args "
                # copy redundant to kernel_boot_args
                flash_erase $KERNEL_BOOT_ARGS_FILE 0 0 &> /dev/null
                dd if=$REDUND_KERNEL_BOOT_ARGS_FILE of=$TEMP_FILE bs=2048 count=1 &> /dev/null
                nandwrite -p $KERNEL_BOOT_ARGS_FILE $TEMP_FILE &> /dev/null
        fi


        sync

else
        # compare the CRC proceed if they are equal
        echo "CRC Match... No Action Required..."
fi

rm $TEMP_FILE
sync
echo "Completed..."

status_file=/var/run/swupdate-status

# start_log
# Mount Upgrade partition
mount /dev/mmcblk0p4 /mnt/usb
mkdir -p /mnt/usb/conf
mkdir -p /mnt/usb/qmlroot
mkdir -p /mnt/usb/upgrade
mkdir -p /mnt/usb/logs
modprobe g_mass_storage

modprobe -r g_multi
modprobe -r g_ether
#ip addr add 192.168.3.2/24 dev usb0
#ip link set usb0 up
modprobe g_serial \
        idVendor="0x16D0" \
        idProduct="0x0001" \
        iSerialNumber="0123456789" \
        iManufacturer="Haltech" \
        iProduct="Haltech"

echo "Enabled g_serial" >> /opt/applications/scipts/swupdate-scripts/modlog.log


systemctl disable dropbear.socket
systemctl stop dropbear.socket
systemctl stop dropbear@*

# Copying the version information to the mass storage partition
mkdir -p /mnt/usb/system_version
cp /opt/version /mnt/usb/system_version/os_version
cp /opt/applications/gui/version /mnt/usb/system_version/app_version
cp /opt/applications/gui/i2c_version /mnt/usb/system_version/i2c_version

# This should fix gpu fix throttling issue with gpu at goit down to 1/64 speed at 85 °C
echo 64 > /sys/bus/platform/drivers/galcore/gpu3DMinClock
# Performance governor will keep the CPU at the highest possible frequency
echo performance > /sys/devices/system/cpu/cpu0/cpufreq/scaling_governor
sync

for arg; do
    case $arg in
        -check)  update=2    ;;
        -update) update=1    ;;
        -delay)  delay=y     ;;
        -force)  force=y     ;;
        -offline)offline=y   ;;
        *)       echo "Invalid option $arg"
                 exit 1
                 ;;
    esac
done

if [ "$delay" = y ]; then
    DELAY=$[ $RANDOM % 3600 ]
    echo "Sleeping for $DELAY seconds"
    sleep $DELAY
fi

machine='var-som-mx6'

echo "---Start of Logs---" >>/mnt/usb/logs/upgradeStatus.log

if [ "$offline" = y ]; then
	
    for dev in /mnt/usb/upgrade; do
        # reverse order gives preference to an unversioned file
        # followed by that with the most recent timestamp if
        # multiple files var-swu-image
        SWU=$(ls -r $dev/*.swu 2>/dev/null | head -n1)
        test -f "$SWU" && break
    done

    for dev in /mnt/usb/upgrade; do
        # reverse order gives preference to an unversioned file
        # followed by that with the most recent timestamp if
        # multiple files var-swu-image
        #SWU=$(ls -r $dev/*.swu 2>/dev/null | head -n1)
        ENC=$(ls -r $dev/*.enc 2>/dev/null | head -n1)
        test -f "$ENC" && echo "Encrypted file found: $ENC" >>/opt/applications/SoftwareUpgrade.log
        test -f "$ENC" && decrypt_swu "$ENC"
        test -f "$SWU" && echo "Decrypted file: $SWU" >>/opt/applications/SoftwareUpgrade.log
        test -f "$SWU" && break
    done
    if [ -f "$SWU" ]; then
        echo "Update found on $dev" >>/opt/applications/SoftwareUpgrade.log
        systemctl stop watchdog-launcher
        rm -rf /opt/applications/dtn/app/dash_display_app
        sync
        cd /opt/applications/gui/
        ./software_update_static &
        cd -
        sync
        echo "Update found on $dev"
        feed="$dev"
    else
        # do run once scripts
        if [ -f /opt/applications/scripts/swupdate-scripts/runonce.sh ]; then
            if [ -f /opt/applications/scripts/general-scripts/run_script.sh ]; then
                rm -rf /opt/applications/scripts/general-scripts/run_script.sh
                rm -rf /opt/applications/scripts/general-scripts/dashstm.sh
                echo "Old run_script.sh file removed" >>/mnt/usb/logs/upgradeStatus.log
            else
                echo "Old run_script.sh file not found" >>/mnt/usb/logs/upgradeStatus.log
            fi
            cp -rf /opt/applications/scripts/swupdate-scripts/runonce.sh /opt/applications/scripts/general-scripts/run_script.sh
            cp -rf /opt/applications/scripts/swupdate-scripts/dashstm.sh /opt/applications/scripts/general-scripts/dashstm.sh
            cp -rf /opt/applications/scripts/swupdate-scripts/uart_tester /opt/applications/scripts/general-scripts/uart_tester
            echo "New runonce.sh STM update file copied" >>/mnt/usb/logs/upgradeStatus.log
            rm -rf /opt/applications/scripts/swupdate-scripts/runonce.sh
            rm -rf /opt/applications/scripts/swupdate-scripts/dashstm.sh
            #echo "Stopping GUI" >>/mnt/usb/logs/upgradeStatus.log
	          #systemctl stop watchdog-launcher
            #echo "Running the copied STM update" >>/mnt/usb/logs/upgradeStatus.log
            #source /opt/applications/scripts/general-scripts/run_script.sh
            #echo "Starting GUI and Watchdog" >>/mnt/usb/logs/upgradeStatus.log
            systemctl start watchdog-launcher
            count=$(ls -1 /opt/applications/gui/*.log 2>/dev/null | wc -l)
            if [ $count != 0 ]; then
                echo "-> Haltech Logs Copied" >>/mnt/usb/logs/upgradeStatus.log
                #rm -rf /mnt/usb/logs/*.log
                #cp -rf /opt/applications/gui/*.log /mnt/usb/logs/
            else
                echo "-> Haltech Logs not present." >>/mnt/usb/logs/upgradeStatus.log
            fi
            if [ -f /opt/applications/scripts/general-scripts/*.log ]; then
                echo "-> Script Logs Copied" >>/mnt/usb/logs/upgradeStatus.log
                cp -rf /opt/applications/scripts/general-scripts/*.log /mnt/usb/logs/
                cp -rf /opt/applications/scripts/general-scripts/*.log /mnt/usb/logs/old
                rm -rf /opt/applications/scripts/general-scripts/*.log
            else
                echo "-> Script Logs not present." >>/mnt/usb/logs/upgradeStatus.log
            fi
            #cp -rf upgradeStatus.log /mnt/usb/logs/
        else
            cp -rf /mnt/usb/logs/*.log /mnt/usb/logs/old
            echo "run_script.sh file not found!" >>/mnt/usb/logs/upgradeStatus.log
        fi
       # do controller firmware upgrade
        if [ -f /mnt/usb/upgrade/*.fwu ]; then
           if [ -f /opt/applications/scripts/general-scripts/run_script.sh ]; then
              rm -rf /opt/applications/scripts/general-scripts/run_script.sh
			  echo "Old run_script.sh file removed"  >>/mnt/usb/logs/upgradeStatus.log
           else
              echo "Old run_script.sh file not found"  >>/mnt/usb/logs/upgradeStatus.log
           fi
		   for f in /mnt/usb/upgrade/*.fwu ; do
				cp  -rf "$f"  /opt/applications/scripts/general-scripts/run_script.sh
				echo "New $f firmware update file copied"  >>/mnt/usb/logs/upgradeStatus.log
				break
		   done
           rm -rf /mnt/usb/upgrade/*.fwu
		   echo "Usb fwu files removed"  >>/mnt/usb/logs/upgradeStatus.log
           echo "Stopping GUI" >>/mnt/usb/logs/upgradeStatus.log
       	   systemctl stop watchdog-launcher
	   echo "Running the copied firmware update"  >>/mnt/usb/logs/upgradeStatus.log
	   source /opt/applications/scripts/general-scripts/run_script.sh
           echo "Starting GUI" >>/mnt/usb/logs/upgradeStatus.log
           systemctl start watchdog-launcher
			if [ -f /opt/applications/scripts/general-scripts/*.log ]; then
				echo "-> Script Logs Copied" >>/mnt/usb/logs/upgradeStatus.log
				cp -rf /opt/applications/scripts/general-scripts/*.log /mnt/usb/logs/
				rm -rf /opt/applications/scripts/general-scripts/*.log
		   else
				echo "-> Script Logs not present." >>/mnt/usb/logs/upgradeStatus.log
		   fi			
	   #cp -rf upgradeStatus.log /mnt/usb/logs/			
       else
            echo "run_script.sh file not found!"  >>/mnt/usb/logs/upgradeStatus.log
       fi		
       # copy mac_address and serial number files
        if [ -f /opt/applications/gui/serial_number ]; then
           cp /opt/applications/gui/serial_number /mnt/usb/system_version/serial_number
           echo "Serial number file copied to Usb."  >>/mnt/usb/logs/upgradeStatus.log
        else
           if [ -f /mnt/usb/system_version/serial_number.txt ]; then
              cp /mnt/usb/system_version/serial_number.txt /opt/applications/gui/serial_number
              rm -rf /mnt/usb/system_version/serial_number.txt
              cp /opt/applications/gui/serial_number /mnt/usb/system_version/serial_number
              echo "Serial number file copied From and To Usb."  >>/mnt/usb/logs/upgradeStatus.log
           else
              echo " -> Serial number file not found. " >>/mnt/usb/logs/upgradeStatus.log
           fi
        fi
        if [ -f /opt/applications/gui/mac_address.txt ]; then
           cp /opt/applications/gui/mac_address.txt /mnt/usb/system_version/mac_address
           echo "Mac Address file copied to Usb."  >>/mnt/usb/logs/upgradeStatus.log
        else
           echo " -> Mac Address file not found. " >>/mnt/usb/logs/upgradeStatus.log
        fi
        echo "-> Update not found. Exit." >>/mnt/usb/logs/upgradeStatus.log
        swu_status -3


        # Check Mac Address hash file exists.
        if [ -f /opt/applications/conf/macAddrHash.txt ]; then
            echo "-> MAC Addr Hash Present." >>/mnt/usb/logs/upgradeStatus.log
        else
            IFACE=eth0
            read MAC </sys/class/net/$IFACE/address
            hash="$(echo -n "$MAC" | md5sum )"
            echo $hash > /opt/applications/conf/macAddrHash.txt
            echo "-> MAC Addr Hash Created." >>/mnt/usb/logs/upgradeStatus.log
        fi
        # Disable service. Remove this from the build.
        if [ -f /opt/applications/removeServices.txt ]; then
           systemctl stop watchdog-launcher
           sync
           cd /opt/applications/gui/
           ./software_update_static &
           cd -
           sync
           echo "Disabling services."
           systemctl disable bluetooth.service
           systemctl disable busybox-klogd.service
           systemctl disable systemd-networkd.socket
           systemctl disable systemd-networkd.service
           systemctl disable systemd-networkd-wait-online.service
           systemctl disable systemd-logind.service
           systemctl disable systemd-hostnamed.service
           systemctl disable swupdate
           systemctl disable remote-fs.target
           systemctl disable rpcbind.socket
           systemctl disable syslog.service
           rm /lib/systemd/system/systemd-journald*
           rm /lib/systemd/system/systemd-update-utmp*
           rm /lib/systemd/system/systemd-logind.service
           rm /opt/applications/removeServices.txt
           sync

           # formating the mass storage partition
           umount /mnt/usb
           mkfs.vfat /dev/mmcblk0p4
           sync

           reboot
        fi
        echo "---End of Logs--- Starting Application " >>/mnt/usb/logs/upgradeStatus.log
        # Remove files from the qml folder
        rm -rf /mnt/usb/qmlroot/*
        rm -rf /mnt/usb/conf/*
        #mv upgradeStatus.log /mnt/usb/logs/upgradeStatus2.log
        # Expose upgrade partition to windows as mass storage
        #umount /dev/mmcblk0p4
	      systemctl start watchdog-launcher

        sync
        #modprobe g_acm_ms file=/dev/mmcblk0p4 removable=1 ro=0 stall=0

        exit 0
    fi
else
    feed='release'

    URL_BASE=https:/somesite.com/feeds/ied/${feed}/images/${machine}
    SWU=${URL_BASE}/var-swu-image-${machine}.swu
fi

echo "Out of offline status..." >>/opt/applications/SoftwareUpgrade.log
echo "Retrieving latest version (feed=$feed)..." >>/mnt/usb/logs/upgradeStatus.log
swu_status 1

cur_version=$(get_version)
swu_version=$(get_swu_version "$SWU")
if [ -z "$swu_version" ]; then
   echo "Setting software version to 1.0." >>/opt/applications/SoftwareUpgrade.log
   swu_version="1.0"
fi
if [ -z "$swu_version" ]; then
    echo "Unable to retrieve latest software version, exit." >>/opt/applications/SoftwareUpgrade.log
    swu_status -1
    rm -rf "$SWU"
    echo "Rebooting..." >>/mnt/usb/logs/upgradeStatus.log
    reboot
    exit 1
fi

cur_build=${cur_version%% *}
swu_build=${swu_version%% *}

if [ "$offline" != y ]; then
    # change SWU urlvar-swu-image full name
    SWU=${URL_BASE}/var-swu-image-${machine}-${swu_version// /-}.swu
fi

echo "installed: $cur_version" >>/mnt/usb/logs/upgradeStatus.log
echo "available: $swu_version" >>/mnt/usb/logs/upgradeStatus.log

#The version check is not yet implemented.
#if [ "$force" != y -a "${swu_build}" -le "${cur_build}" ]; then
#    echo "No newer version available, exit."
#    swu_status 0
#    exit
#fi

if [ "$update" != 1 ]; then
    swu_status 0 "$swu_version"
    exit
fi

altroot=$(get_altrootfs)

if [ -z "$altroot" ]; then
    echo "Unable to determine rootfs. Exit.">>/opt/applications/SoftwareUpgrade.log
    swu_status -2 "$swu_version"
    exit 1
fi

if ! lock; then
    echo "Can't get lock, other process already running? Exit." >>/opt/applications/SoftwareUpgrade.log
    swu_status 0 "$swu_version"
    exit
fi

echo "Starting swupdate to install version $swu_version ..." >>/mnt/usb/logs/upgradeStatus.log
swu_status 2 "$swu_version"

# backup rootfs is about to be replaced, remove its version entry
get_version >/var/run/versions

if [ -f "$SWU" ]; then
    swupdate_flags="-i"
else
    swupdate_flags="-t 30 -r 3 -d"
fi

# if [ "$SWU" = "/mnt/usb/upgrade/opt-applications-var-som-mx6.tar.bz2" ]; then
# echo "SW Update is upgrading opt-applications, backing up conf directory."
# backup_conf
# fi;

# Run indicator to display that sw update is running.
#Stop any indicator if it is already running.
ps -ef | grep indicate_upgrade | grep -v grep | awk '{print $2}' | xargs kill
/tmp/scripts/general-scripts/indicate_upgrade.sh 0 &

if do_swupdate -v $swupdate_flags "$SWU" -e "stable,copy$altroot"; then
    echo "do_swupdate completed OK [stable,copy$altroot]." >>/mnt/usb/logs/upgradeStatus.log
    swu_status 3 "$swu_version"

    if [ "$altroot" == 1 ]; then
        echo "do_swupdate flashed active partition." >>/mnt/usb/logs/upgradeStatus.log
        echo "Active and passive partitions have been updated. Deleting the upgrade and conf file." >>/mnt/usb/logs/upgradeStatus.log
        rm -rf "$SWU"

        # if [ "$SWU" = "/mnt/usb/upgrade/opt-applications-imx6ul-schenck-dart.tar.bz2" ]; then
        # echo "Upgraded opt-applications, restoring conf directory."
        # restore_conf
        # rm -rf /mnt/usb/upgrade/conf_backup.tgz
        # fi;

    else
        echo "do_swupdate flashed passive partition. Doing a reboot to flash the active partition." >>/mnt/usb/logs/upgradeStatus.log
    fi

    # Run indicator to display that sw update was a success.
    #Stop indicator if it is already running.
    ps -ef | grep indicate_upgrade | grep -v grep | awk '{print $2}' | xargs kill
    /tmp/scripts/general-scripts/indicate_upgrade.sh 1

    echo "Rebooting..." >>/mnt/usb/logs/upgradeStatus.log
    reboot
else
    # Run indicator to display that sw update was a failure.
    #Stop indicator if it is already running.
    ps -ef | grep indicate_upgrade | grep -v grep | awk '{print $2}' | xargs kill
    /tmp/scripts/general-scripts/indicate_upgrade.sh 2

    echo "Error, do_swupdate stopped with exitcode $?, unlock and exit." >>/mnt/usb/logs/upgradeStatus.log
    swu_status -2 "$swu_version"
    rm -rf "$SWU"
    echo "Rebooting..." >>/mnt/usb/logs/upgradeStatus.log
    reboot
fi

unlock
