# get average of list

from statistics import mean
from math import floor


def get_average(marks):
    return floor(mean(marks))


print(get_average([2, 3, 4, 5]))  # 3
