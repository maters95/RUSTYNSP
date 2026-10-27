#! /bin/sh

. $(dirname $0)/functions.sh

version=/opt/version
app_version=/opt/applications/gui/version
altroot=/mnt/backup_rootfs

echo "Active rootfs:" $(get_rootfs)

get_version $version | tee -a /var/run/versions | sed 's/^/Active OS Build version: /'

other=$(get_altrootfs)

if [ -z "$other" ]; then
    echo "Unable to determine backup rootfs"
    exit 1
fi

lock || exit

mkdir -p $altroot
dmesg --console-off
if (mount -r -t $rootfstype $(get_rootdev $other) $altroot) >/dev/null 2>/dev/null; then
    get_version $altroot/$version | tee -a /var/run/versions |
        sed 's/^/Backup OS Build version: /'
    umount $altroot
else
    echo "Error while mounting backup rootfs."
fi
dmesg --console-on
rm -rf $altroot


get_version $app_version | tee -a /var/run/versions | sed 's/^/Active apps version: /'
echo

unlock
