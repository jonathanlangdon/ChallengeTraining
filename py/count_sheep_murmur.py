# count sheep based on integer input


def count_sheep(n):
    murmur = ""
    for i in range(n):
        murmur += f"{i + 1} sheep..."
    return murmur


print(count_sheep(3))  # "1 sheep...2 sheep...3 sheep..."
