# Create colored triangle


def triangle(row):
    if len(row) == 1:
        return row
    new_row = ""
    for i in range(1, len(row)):
        new_row += combine_colors(row[i - 1 : i + 1])
    return triangle(new_row)


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
