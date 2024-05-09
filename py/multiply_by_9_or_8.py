# multiply by eight if even, by 9 if odd

simple_multiplication = lambda num: num * (8 if num % 2 == 0 else 9)

print(simple_multiplication(4))  # 32
print(simple_multiplication(3))  # 27
