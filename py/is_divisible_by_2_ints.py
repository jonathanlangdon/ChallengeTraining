# check if a number is divisible by 2 input numbers

def is_divisible(n, x, y):
    return n % x == 0 and n % y == 0

print(is_divisible(12, 2, 6)) # True
print(is_divisible(12, 7, 4)) # False