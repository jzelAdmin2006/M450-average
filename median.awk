{
    numbers[NR] = $1
}
END {
    middle = int((NR + 1) / 2)
    if (NR % 2 == 1) {
        print numbers[middle]
    } else {
        print (numbers[middle] + numbers[middle + 1]) / 2
    }
}
