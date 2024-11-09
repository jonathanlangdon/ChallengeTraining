# determine how many times hotpo must run to reach 1


def hotpo(n):
    count = 0
    while n > 1:
        n = n / 2 if n % 2 == 0 else n * 3 + 1
        count += 1
    return count
