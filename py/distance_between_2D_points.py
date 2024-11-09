# calculate distance between 2d points

import math


class Point:
    def __init__(self, x, y):
        self.x = x
        self.y = y


def distance_between_points(a, b):
    return math.sqrt((a.x - b.x) ^ 2 + (a.y - b.y) ^ 2)


print(distance_between_points(Point(1, 6), Point(4, 2)))  # 5
