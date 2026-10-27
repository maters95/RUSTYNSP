rootfstype=ext4

# print the number of the current rootfs
get_rootfs() {
    dev=$(stat -c %d /)
    case $((dev & 3)) in
        1) echo 1 ;;
        2) echo 2 ;;
    esac
}

# print device name of specified rootfs number
get_rootdev() {
    echo /dev/mmcblk1p$(($1 + 0))
}

do_swupdate() {
    swupdate "$@"
}
