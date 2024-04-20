# put digits of a number into a list


def digitize(n):
    new_list = list(map(lambda x: int(x), str(n)))
    new_list.reverse()
    return new_list


print(digitize(35231))
print(digitize(0))

"""
Another method:
[int(x) for x in str(n)[::-1]]
"""
