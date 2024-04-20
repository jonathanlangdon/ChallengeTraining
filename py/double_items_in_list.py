# given a list, double each value

maps = lambda numbers: list(map(lambda x: x * 2, numbers))

print(maps([1,2,3])) # 2,4,6


'''
other method:

    new_numbers = []
    for num in numbers:
        new_numbers.append(num * 2)
    return new_numbers
'''