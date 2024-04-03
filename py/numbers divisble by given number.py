# from a list and int input, get which items are divisible by the int


def divisible_by(numbers, divisor):
    return list(filter(lambda x: x % divisor == 0, numbers))


""" divisor. First argument is an array of numbers and the second is the divisor.
Example(Input1, Input2 --> Output)

[1, 2, 3, 4, 5, 6], 2 --> [2, 4, 6]

"""
