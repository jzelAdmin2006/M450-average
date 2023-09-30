#!/usr/bin/env bash

set -euo pipefail

cat << EOF > mean_test_data.txt
1
2
3
EOF

actual=$(dotnet run --project Average.Demo mean mean_test_data.txt)

expected=2

rm mean_test_data.txt

if [[ "$actual" != "$expected" ]]; then
	exit 1
fi
