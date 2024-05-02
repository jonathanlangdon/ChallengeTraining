# given list of numbers, return inverse of each


def invert(the_list):
    return [-x for x in the_list]


print(invert([-1, 2, 3, -4]))  # 1, -2, -3, 4

""" other method

    new_list = []
    for item in the_list:
        new_list.append(-item)
    return new_list

"""
