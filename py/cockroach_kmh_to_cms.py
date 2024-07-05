# convert km/h to cm/s rounded down

from math import floor


def cockroach_speed(s):
    return floor(s * 100 / 3.6)


print(cockroach_speed(1.08))  # 30
