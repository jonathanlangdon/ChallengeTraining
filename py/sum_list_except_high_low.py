# return sum of a list except highest and lowest value


def sum_list(the_list):
    if not the_list:
        return 0
    return sum(sorted(the_list)[1:-1])


# Arrays are called lists in Python
sum_array = sum_list

print(sum_array([6, 2, 1, 8, 10]))  # 16
print(sum_array([3, 5]))  # 0
print(sum_array([3]))  # 0
print(sum_array(None))  # 0
print(sum_array([]))  # 0

# Other Methods:

"""
1) remove max & min
2) use the_list.sort() -> but not pure function


Evelyn
 Diego
 Mouse a cookie
 Max Ruby
 Cliffords Puppy Days
 Clifford
 Paw Patrol
 Dora
 Busytown
 Daniel Tiger


Brielle
 Max Ruby
 Cliffords Puppy Days
 Clifford
Diego
 """
