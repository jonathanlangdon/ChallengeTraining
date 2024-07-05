# check if a base has a factor


def check_for_factor(base, factor):
    return base % factor == 0


print(check_for_factor(9, 3))  # True
print(check_for_factor(9, 2))  # False
