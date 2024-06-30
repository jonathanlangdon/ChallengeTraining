# repeat each character in string input


def double_char(s):
    new_str = ""
    for char in s:
        new_str += char + char
    return new_str


print(double_char("hello"))  # hheelllloo
