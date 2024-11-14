# solve a 9x9 deterministic sudoku problem


def sudoku(puzzle):

    def checkPossibles(y_index, x_index):
        possible = [1, 2, 3, 4, 5, 6, 7, 8, 9]
        row = puzzle[y_index]
        column = [row[x_index] for row in puzzle]
        box = getBoxNums(y_index, x_index)
        possible = [num for num in possible if num not in row]
        possible = [num for num in possible if num not in column]
        possible = [num for num in possible if num not in box]
        return possible

    def getBoxNums(y_index, x_index):
        nums = []
        groups = [0, 1, 2], [3, 4, 5], [6, 7, 8]
        box_x_values = groups[x_index // 3]
        box_y_values = groups[y_index // 3]
        for y in box_y_values:
            for x in box_x_values:
                nums.append(puzzle[y][x])
        return nums

    while any(0 in row for row in puzzle):
        for y_index, row in enumerate(puzzle):
            for x_index, num in enumerate(row):
                if num != 0:
                    continue
                possible = checkPossibles(y_index, x_index)
                if len(possible) == 1:
                    puzzle[y_index][x_index] = possible[0]

    return puzzle


result = sudoku(
    [
        [5, 3, 0, 0, 7, 0, 0, 0, 0],
        [6, 0, 0, 1, 9, 5, 0, 0, 0],
        [0, 9, 8, 0, 0, 0, 0, 6, 0],
        [8, 0, 0, 0, 6, 0, 0, 0, 3],
        [4, 0, 0, 8, 0, 3, 0, 0, 1],
        [7, 0, 0, 0, 2, 0, 0, 0, 6],
        [0, 6, 0, 0, 0, 0, 2, 8, 0],
        [0, 0, 0, 4, 1, 9, 0, 0, 5],
        [0, 0, 0, 0, 8, 0, 0, 7, 9],
    ]
)

for row in result:
    print(row)


"""
Should return
 [[5,3,4,6,7,8,9,1,2],
  [6,7,2,1,9,5,3,4,8],
  [1,9,8,3,4,2,5,6,7],
  [8,5,9,7,6,1,4,2,3],
  [4,2,6,8,5,3,7,9,1],
  [7,1,3,9,2,4,8,5,6],
  [9,6,1,5,3,7,2,8,4],
  [2,8,7,4,1,9,6,3,5],
  [3,4,5,2,8,6,1,7,9]]
"""
