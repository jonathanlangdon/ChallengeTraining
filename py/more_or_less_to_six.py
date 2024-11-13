# determine how many more or less (always positive) to get to 6


def six_toast(num):
    return abs(num - 6)


print(six_toast(15))  # 9
print(six_toast(6))  # 0
print(six_toast(3))  # 3
