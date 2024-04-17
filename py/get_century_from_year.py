## determine the century given the year

import math

def century(year):
    return math.ceil(year / 100)

print(century(1701)) # 18
print(century(1700)) # 17
print(century(1699)) # 17