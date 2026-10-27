#! /bin/bash

echo "Started run_script.sh" >>/mnt/usb/logs/Stm_upgradeStatus.log
return_code=1
source /opt/applications/scripts/general-scripts/dashstm.sh
num_tries=5
sleep 0.5

while [ $num_tries -gt 0 ]
do
    sleep 0.5
    /opt/applications/scripts/general-scripts/uart_tester >> /mnt/usb/logs/Stm_upgradeStatus.log 2>&1
    if [[ $? != 0 ]]
    then
        echo "Trying uart_tester again; try count: $num_tries" >>/mnt/usb/logs/Stm_upgradeStatus.log 
        num_tries=$((num_tries-1))
        source /opt/applications/scripts/general-scripts/dashstm.sh
        sleep 1
    else
        num_tries=0
        return_code=0
    fi
done

echo "Finished run_script.sh; Errorcode: $return_code" >>/mnt/usb/logs/Stm_upgradeStatus.log 
return $return_code
