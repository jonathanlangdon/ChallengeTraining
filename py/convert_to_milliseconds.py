# convert time to milliseconds

past = lambda h, m, s: ((h * 60 + m) * 60 + s) * 1000

print(past(1, 1, 1))  # 3661000
