# return sum of all values in a list (mix of strings and numbers)


def sum_mix(the_list):
    sum = 0
    for item in the_list:
        sum += int(item)
    return sum


print(sum_mix([9, 3, "7", "3"]))  # 22
