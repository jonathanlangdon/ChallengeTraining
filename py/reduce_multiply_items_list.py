# multiply all the values of a list

from functools import reduce

grow = lambda arr: reduce(lambda a, c: a * c, arr)

print(grow([1, 2, 3, 4]))  # 24
