# Determine how much space on a bus

def enough(cap, on, wait):
    if (cap > on + wait): return 0
    return wait +  on - cap

print(enough(10, 5, 5)) # 0
print(enough(100, 60, 50)) # 10
print(enough(20, 5, 5)) #0