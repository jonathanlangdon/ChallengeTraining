# return average of a list

from statistics import mean

find_average = lambda numbers: mean(numbers) if numbers else 0

print(find_average([1, 2, 3, 4]))  # 2.5
print(find_average([]))  # 0
