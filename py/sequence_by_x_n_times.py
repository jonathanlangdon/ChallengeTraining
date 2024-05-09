# Return a sequence of numbers counting by `x` `n` times


def count_by(x, n):
    a_list = []
    for i in range(n):
        a_list.append((i + 1) * x)
    return a_list


print(count_by(1, 5))  # [1, 2, 3, 4, 5]
print(count_by(2, 3))  # [2, 4, 6]


# another method:
#
# return [i * x for i in range(1, n + 1)]
