#!/bin/sh

if [ $# -lt 1 ]; then
	exit 0;
fi

function get_current_root_device
{
	for i in `cat /proc/cmdline`; do
		if [ ${i:0:5} = "root=" ]; then
			CURRENT_ROOT="${i:5}"
		fi
	done
}

function get_update_part
{
	CURRENT_PART="${CURRENT_ROOT: -1}"
	if [ $CURRENT_PART = "1" ]; then
		UPDATE_PART="2";
	else
		UPDATE_PART="1";
	fi
}

function get_update_device
{
	UPDATE_ROOT=${CURRENT_ROOT%?}${UPDATE_PART}
}

function format_update_device
{
	umount $UPDATE_ROOT
	mkfs.ext4 $UPDATE_ROOT -F -L rootfs${UPDATE_PART}
}

if [ $1 == "preinst" ]; then
	# get the current root device
	get_current_root_device

	# get the device to be updated
	get_update_part
	get_update_device

	# format the device to be updated
	format_update_device

	# create a symlink for the update process
	ln -sf $UPDATE_ROOT /dev/update
fi

if [ $1 == "postinst" ]; then
	get_current_root_device

	get_update_part

	KERNEL_BOOT_ARGS="quiet console=ttymxc4,115200  root=/dev/mmcblk0p$UPDATE_PART rootwait rw video=mxcfb0:dev=hdmi,800x480M@60,if=RGB24 video=mxcfb1:off video=mxcfb2:off video=mxcfb3:off"
	KERNEL_BOOT_ARGS_FILE=/dev/mtd1
	REDUND_KERNEL_BOOT_ARGS_FILE=/dev/mtd2
	BOOT_ARGS_FILE=/tmp/update_boot_arg
	TEMP_FILE=/tmp/temp_update_boot_args
	TEMP_FILE2=/tmp/temp_update_boot_args2
	
	echo "Updating the bootargs..."

	echo -n "$KERNEL_BOOT_ARGS" > $BOOT_ARGS_FILE
	kernel_boot_args_crc_hex=$(crc32 $BOOT_ARGS_FILE)

	kernel_boot_args_crc_int=$(echo $((16#$kernel_boot_args_crc_hex)))
	kernel_boot_args_crc=$(printf "%08x" $kernel_boot_args_crc_int)
	echo kernel_boot_args_crc:$kernel_boot_args_crc

	# calculate the payload size
	wc -c $BOOT_ARGS_FILE | awk '{print $1}' > $TEMP_FILE
	read kernel_boot_args_len_int < $TEMP_FILE
	kernel_boot_args_len=$(printf "%08x" $kernel_boot_args_len_int)
	echo kernel_boot_args_len:$kernel_boot_args_len

	# generating the bootargs bin
	echo -n ${kernel_boot_args_len:6:2}${kernel_boot_args_len:4:2}${kernel_boot_args_len:2:2}${kernel_boot_args_len:0:2} | awk -niord '$0=chr("0x"RT)' RS=.. ORS= > $BOOT_ARGS_FILE
	echo -n ${kernel_boot_args_crc:6:2}${kernel_boot_args_crc:4:2}${kernel_boot_args_crc:2:2}${kernel_boot_args_crc:0:2} | awk -niord '$0=chr("0x"RT)' RS=.. ORS= >> $BOOT_ARGS_FILE

	echo -n "$KERNEL_BOOT_ARGS" > $TEMP_FILE

<<comment
	# the last byte gets 0 swapped if the number of bytes is odd
	# while the dd swab operation
	rem=$(($kernel_boot_args_len_int % 2))
	if [ $rem -eq 0 ]; then
		# no action required
		echo "No Aaction Required..."
	else
		# adding a null at the end
		echo  " " >> $TEMP_FILE
	fi

	dd if=$TEMP_FILE of=$TEMP_FILE2 conv=swab &> /dev/null
comment

	read console_arg < $TEMP_FILE
	echo $console_arg
	echo -n "$console_arg" >> $BOOT_ARGS_FILE

	dd if=/dev/zero of=$TEMP_FILE bs=16 count=1 &> /dev/null
	cat $TEMP_FILE >> $BOOT_ARGS_FILE
	
	hexdump $BOOT_ARGS_FILE

	# Update the boot args page
	flash_erase $KERNEL_BOOT_ARGS_FILE 0 0 &> /dev/null
	nandwrite -p $KERNEL_BOOT_ARGS_FILE $BOOT_ARGS_FILE &> /dev/null
	sync
	flash_erase $REDUND_KERNEL_BOOT_ARGS_FILE 0 0 &> /dev/null
	nandwrite -p $REDUND_KERNEL_BOOT_ARGS_FILE $BOOT_ARGS_FILE &> /dev/null
	sync
	echo "Completed..."
fi

