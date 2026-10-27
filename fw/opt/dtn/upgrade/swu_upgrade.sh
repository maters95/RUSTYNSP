#! /bin/bash

# This file should be called from the watchdog/bootloader when a *.ENC or *.SWU file is present at
# /opt/applications/dtn. This script will:
# 1. Attempt to decrypt the .ENC into a .SWU
# 2. Attempt to flash it into the passive parition
# 3. Reboot into passive parition
# 4. Flash the SWU into the active parition
# 5. Reboot into the active parition
# 6. Remove .ENC/.SWU files

# Exit codes
# 0 - Script Ran Successfully
# 1 - SWU file not found

### START Variables ###

LOG_FILE=/mnt/usb/upgrade/SoftwareUpgrade.log

### END Variables ###
### STARTFunctions ###

# Returns the rootfs that is NOT in use.
get_altrootfs() {
    rootfs=$(get_rootfs)
    case $rootfs in
        1) echo 2 ;;
        2) echo 1 ;;
    esac
}

# Returns the rootfs that is in use.
get_rootfs() {
    dev=$(stat -c %d /)
    case $((dev & 3)) in
        1) echo 1 ;;
        2) echo 2 ;;
    esac
}

decrypt_swu() {
      local f="$1"
      echo "$f will be decrypted" >> $LOG_FILE
      SWU="${f}.swu"
      sync
      cd -
      sync
      echo "Starting openssl at $(date +%T)" >> $LOG_FILE
      openssl  aes-128-cbc -d -md md5 -a -in "$f" -out "$SWU" -kfile /opt/applications/dtn/upgrade/password
      wait -f
      sync
      echo "Openssl Completed at $(date +%T)" >> $LOG_FILE
     if [ -f "$SWU" ]; then
        echo "Decrypted file $SWU" >> $LOG_FILE
        rm -f "$f" && echo "Encrypted file $f deleted" >> $LOG_FILE || echo "Encrypted file $f NOT deleted" >> $LOG_FILE
      else
        echo "No decrypted file $SWU" >> $LOG_FILE
        exit 1
      fi
}

### END Functions ###
### START Main ###

# Check that /mnt/usb/upgrade exists as it houses the SWU files
if [ ! -d /mnt/usb/upgrade ]; then
    mount /dev/mmcblk0p4 /mnt/usb
    mkdir -pf /mnt/usb/upgrade
fi

echo "***** Start swu_upgrade script *****" > $LOG_FILE
echo "Rootfs is $(get_rootfs)" >> $LOG_FILE
echo "Alt Rootfs is $(get_altrootfs)" >> $LOG_FILE


# Try decrypt .ENC files into .SWU files
for dev in /mnt/usb/upgrade; do
    ENC=$(ls -r $dev/*.enc 2>/dev/null | head -n1)
    test -f "$ENC" && echo "Encrypted file found: $ENC" >> $LOG_FILE
    test -f "$ENC" && decrypt_swu "$ENC"
    test -f "$SWU" && echo "Decrypted file: $SWU" >> $LOG_FILE
    test -f "$SWU" && break
done

# If the decrypt from above was successful then $SWU will be assigned and this function will NOT run
# Otherwise this lets look for already decrypted SWU's (i.e. on a passive partition install)
if [ -z "$SWU" ]; then
    #ENC file does not exist, but a previously decrypted ENC might now be a SWU
    echo "ENC not found, looking for SWU" >> $LOG_FILE
    for dev in /mnt/usb/upgrade; do
        SWU=$(ls -r $dev/*.swu 2>/dev/null | head -n1)
        test -f "$SWU" && break
    done
    echo "SWU is $SWU" >> $LOG_FILE
else
    echo "Decrypted .enc will be used" >> $LOG_FILE
fi

altroot=$(get_altrootfs)

if [ -f "$SWU" ]; then

    echo "Upgrading on root $altroot" >> $LOG_FILE

    # swupdate utility will change the rootfs partition number from 1 <-> 2. So first pass on this function will be 2, second pass will be 1.
    if swupdate -v -i "$SWU" -e "stable,copy$altroot" >> $LOG_FILE; then
        echo "swupdate completed OK [stable,copy$altroot]." >> $LOG_FILE

        if [ "$altroot" == 1 ]; then
            echo "Active and passive partitions have been updated. Deleting the upgrade file." >> $LOG_FILE
            rm -rf "$SWU"
            rm -rf "$ENC"
        else
            echo "swupdate flashed passive partition. Doing a reboot." >> $LOG_FILE
        fi

        reboot
    else
        # Run indicator to display that sw update was a failure.

        echo "Error, swupdate stopped with exitcode $?" >> $LOG_FILE
        rm -rf "$SWU"
        rm -rf "$ENC"
        reboot
    fi

else
    #SWU file not found
    echo "No swu found - $SWU" >> $LOG_FILE
    exit 1
fi

### END Main ###
