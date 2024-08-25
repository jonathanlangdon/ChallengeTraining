# created function to combine two colors


def triangle(row):
    return combine_colors(row)


def combine_colors(colors):
    if len(colors) == 1:
        return colors
    if colors[0] == colors[1]:
        return colors[0]
    return ({"R", "G", "B"} - set(colors)).pop()


print(triangle("B"))  # B
print(triangle("RR"))  # R
print(triangle("BB"))  # B
print(triangle("BR"))  # G
print(triangle("GR"))  # B
print(triangle("GB"))  # R
print(triangle("RRGBRGBB"))  # G
