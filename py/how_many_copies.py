# determine how many copies needed

paperwork = lambda n, m: 0 if n < 0 or m < 0 else n * m

print(paperwork(1, 2))  # 2
print(paperwork(-5, -2))  # 0
print(paperwork(4, 5))  # 20
