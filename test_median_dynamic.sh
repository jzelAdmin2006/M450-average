#!/usr/bin/env bash

test_size=$((8 + $RANDOM % 43))

for i in {1..test_size}; do
    echo $RANDOM >> random_median_test_data.txt
done

expected=$(sort -n random_median_test_data.txt | awk -f median.awk)

actual=$(dotnet run --project Average.Demo median random_median_test_data.txt)

rm random_median_test_data.txt

if [[ "$actual" != "$expected" ]]; then
    exit 1
fi
