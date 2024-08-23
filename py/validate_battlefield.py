# check all rows for invalid layout


def validate_battlefield(field):
    if count_total_cells(field) != 20:
        return False
    return has_no_diagonal_ships(field)


def count_total_cells(field):
    flat_field = [cell for row in field for cell in row]
    return flat_field.count(1)


def has_no_diagonal_ships(field):
    # no ships should be diagonal with another
    for j in range(0, 9):
        for i in range(1, 10):
            if field[j][i] == 1 and field[j + 1][i - 1] == 1:
                return False
            if field[j][i - 1] == 1 and field[j + 1][i] == 1:
                return False
    return True


battleField = [
    [1, 0, 0, 0, 0, 1, 1, 0, 0, 0],
    [1, 0, 0, 0, 0, 0, 0, 0, 1, 0],
    [1, 0, 1, 0, 1, 1, 1, 0, 1, 0],
    [1, 0, 1, 0, 0, 0, 0, 0, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 0, 1, 0],
    [0, 0, 0, 0, 1, 1, 1, 0, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 0, 1, 0],
    [0, 0, 0, 1, 0, 0, 0, 0, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 1, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
]

print(count_total_cells(battleField))
print(validate_battlefield(battleField))
print(has_no_diagonal_ships(battleField))
