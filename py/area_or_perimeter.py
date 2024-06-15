# determine either area or perimeter depending on if square or not


def area_or_perimeter(l, w):
    return l * w if l == w else 2 * (l + w)


print(area_or_perimeter(6, 10))  # 32
print(area_or_perimeter(3, 3))  # 9
