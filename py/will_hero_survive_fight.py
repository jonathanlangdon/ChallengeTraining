# determine if hero will survive fight with dragons

hero = lambda bullets, dragons: bullets / 2 >= dragons

print(hero(10, 5))  # True
print(hero(7, 4))  # False
print(hero(4, 5))  # False
print(hero(100, 40))  # True
print(hero(1500, 751))  # False
print(hero(0, 1))  # False
