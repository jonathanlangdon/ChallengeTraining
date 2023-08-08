# count number of sheep (true)


def count_sheeps(pen):
    count = 0
    for sheep in pen:
        if sheep:
            count += 1
    return count


array1 = [
    True,
    True,
    True,
    False,
    True,
    True,
    True,
    True,
    True,
    False,
    True,
    False,
    True,
    False,
    False,
    True,
    True,
    True,
    True,
    True,
    False,
    False,
    True,
    True,
]

print(count_sheeps(array1))
