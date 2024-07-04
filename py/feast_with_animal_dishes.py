# determine whether an input animal has the same start and end letter as a dish

def feast(beast, dish):
    return beast[0] == dish[0] and beast[-1] == dish[-1]

print(feast("chickadee", "chocolate cake")) # True
print(feast("chickadee", "vanilla cake")) # False