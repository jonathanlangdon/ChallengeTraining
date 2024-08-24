# confirm correct ship list. Done!


def validate_battlefield(field):
    return has_no_diagonal_ships(field) and has_valid_ship_count(field)


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
    for i in range(0, 10):  # go through each row
        ship_size = 0
        for j in range(0, 10):
            cur_cell = field[i][j]
            if cur_cell == 0 and ship_size > 0:
                horiz_ship_list.append(ship_size)
                ship_size = 0  # log ship size and reset
            elif cur_cell == 1:
                # check to make sure not vertical ship
                if field[i - 1][j] == 1 or field[i + 1][j] == 1:
                    continue
                ship_size += 1  # update ship size
            if j == 9 and ship_size > 0:
                horiz_ship_list.append(ship_size)  # log last ship
    return horiz_ship_list


def list_vertical_ships(field):
    vertical_ship_list = []
    for i in range(0, 10):  # across columns
        ship_size = 0
        for j in range(0, 10):  # go down column
            cur_cell = field[j][i]
            if cur_cell == 0:
                if ship_size == 1:
                    ship_size = 0  # don't store size 1 ships (already in horiz list)
                elif ship_size > 1:
                    vertical_ship_list.append(ship_size)
                    ship_size = 0  # log ship size and reset
            elif cur_cell == 1:
                # check to make sure not horizontal ship
                if field[j][i - 1] == 1 or field[j][i + 1] == 1:
                    continue
                ship_size += 1  # update ship size
            if j == 9 and ship_size > 1:
                vertical_ship_list.append(ship_size)  # log last ship
    return vertical_ship_list


def get_all_ships(field):
    vert_ships = list_vertical_ships(field)
    horiz_ships = list_horiz_ships(field)
    all_ships = vert_ships + horiz_ships
    all_ships.sort()
    return all_ships


def has_valid_ship_count(field):
    return get_all_ships(field) == [1, 1, 1, 1, 2, 2, 2, 3, 3, 4]


battleField = [
    [1, 0, 0, 0, 0, 1, 1, 0, 0, 0],
    [1, 0, 0, 0, 0, 0, 0, 0, 1, 0],
    [1, 0, 1, 0, 1, 1, 1, 0, 1, 0],
    [1, 0, 1, 0, 0, 0, 0, 0, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 0, 1, 0],
    [0, 1, 0, 0, 1, 1, 1, 0, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 0, 1, 0],
    [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 1, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
]

print(validate_battlefield(battleField))
