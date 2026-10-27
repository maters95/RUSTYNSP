#!/bin/sh
# Create MAC Address hash file
IFACE=eth0
read MAC </sys/class/net/$IFACE/address
hash="$(echo -n "$MAC" | md5sum )"
echo $hash > /opt/applications/conf/macAddrHash.txt
echo "-> MAC Addr Hash Created." >> upgradeStatus.log

