# put horizontal ships in a list


def validate_battlefield(field):
    if count_total_cells(field) != 20:
        return False
    return has_no_diagonal_ships(field)


def count_total_cells(field):
    flat_field = [cell for row in field for cell in row]
    return flat_field.count(1)


def has_no_diagonal_ships(field):
    # no ships should be diagonal with another
    for i in range(0, 9):
        for j in range(1, 10):
            if field[i][j] == 1 and field[i + 1][j - 1] == 1:
                return False
            if field[i][j - 1] == 1 and field[i + 1][j] == 1:
                return False
    return True


def list_horiz_ships(field):
    horiz_ship_list = []
    for i in range(0, 10):
        ship_size = 0
        for j in range(0, 10):
            cur_cell = field[i][j]
            if cur_cell == 0 and ship_size > 0:
                horiz_ship_list.append(ship_size)
                ship_size = 0  # log ship size and continue
            elif cur_cell == 1:
                # check to make sure not vertical ship
                if field[i - 1][j] == 1 or field[i + 1][j] == 1:
                    continue
                ship_size += 1  # update ship size
            if j == 9 and ship_size > 0:
                horiz_ship_list.append(ship_size)  # log last ship
    return horiz_ship_list


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
print(list_horiz_ships(battleField))
