# return array of numbers from n down to 1


def reverse_seq(n):
    return [i for i in range(n, 0, -1)]


print(reverse_seq(3))  # [3, 2, 1]
