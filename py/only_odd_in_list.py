# return only list with odd numbers

odds = lambda num_list: [num for num in num_list if num % 2 != 0]


print(odds([1, 2, 3, 4, 5]))  # [1, 3, 5]
print(odds([1, 2, 4]))  # [1]
print(odds([2, 4]))  # []
