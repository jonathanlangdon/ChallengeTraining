# Check validity of 1st row


def validate_battlefield(field):
    if count_total_cells(field) != 20:
        return False
    else:
        return True


def count_total_cells(field):
    flat_field = [cell for row in field for cell in row]
    return flat_field.count(1)


def first_row_is_valid(field):
    # no ships should be diagonal with another
    for i in range(1, 10):
        if field[0][i] == 1 and field[1][i - 1] == 1:
            return False
        if field[0][i - 1] == 1 and field[1][i] == 1:
            return False
    return True


battleField = [
    [1, 0, 0, 0, 0, 1, 1, 0, 0, 0],
    [1, 0, 1, 0, 0, 0, 0, 0, 1, 0],
    [1, 0, 1, 0, 1, 1, 1, 0, 1, 0],
    [1, 0, 0, 0, 0, 0, 0, 0, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 0, 1, 0],
    [0, 0, 0, 0, 1, 1, 1, 0, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 0, 1, 0],
    [0, 0, 0, 1, 0, 0, 0, 0, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 1, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
]

print(count_total_cells(battleField))
print(validate_battlefield(battleField))
print(first_row_is_valid(battleField))
