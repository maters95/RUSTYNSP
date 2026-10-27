#! /bin/bash

# Return codes
# 0 - Upgraded successfully
# 1 - Failed to upgrade

return_code=1

THIS_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
source ${THIS_DIR}/run_script.sh
num_tries=5
sleep 0.5
while [ $num_tries -gt 0 ]
do
    sleep 0.5
    read -r -t6 -n1 < /dev/ttymxc3
    if [[ $? != 0 ]]
    then
        num_tries=$((num_tries-1))
        echo "STM did not upgrade, on try ${num_tries}"
        source ${THIS_DIR}/run_script.sh
        sleep 1
    else
        echo "STM upgrade successful"
        num_tries=0
        return_code=0
    fi
done

exit $return_code
