# return what quarter a month belongs to

import math


def quarter_of(month):
    return math.ceil(month / 3)


print(quarter_of(2))  # 1
print(quarter_of(3))  # 1
print(quarter_of(4))  # 2
print(quarter_of(11))  # 4
