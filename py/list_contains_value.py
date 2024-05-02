# does array a contain value x?

check = lambda seq, elem: elem in seq

print(check([3, 5, 6, 1], 5))  # true
print(check([3, 5, 6, 1], 7))  # false
