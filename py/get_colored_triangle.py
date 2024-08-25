# Create colored triangle

import timeit


def triangle(row):
    new_row = row
    for i in range(1, len(row)):
        new_row = get_next_row(new_row)
    return new_row


def get_next_row(row):
    new_row = ""
    for i in range(1, len(row)):
        new_row += combine_colors(row[i - 1 : i + 1])
    return new_row


def combine_colors(colors):
    c1, c2 = colors
    if c1 is c2:
        return c1
    color_list = ["R", "G", "B"]
    color_list.remove(c1)
    color_list.remove(c2)
    return color_list[0]


# print(triangle("RBRGBRBGGRRRBGBBBGG"))  # 'G'

# print("-----710 length ----")
length710 = "RRBGBRRRRGRGBGRGBBRRBBRBGGRRRGGGRGBGGGBGRRBBRBBBBGGRBGRGRGGBBBBGGGRRBBGRBRGBRGBGGRRBGRGRBRGBGGGRBRRGBBGGGGRRBGGRGRBGGGBGRGBGGBGBRBBBBBGGBGGBRBRGBBGRBRRGRRRRRRGBBRRBBRBBRBBGGRRBRRBGGRRGRGBRBGRBRGBRGBGGGBBBBBBBRRBGBRBGBGGRBRBBGGGGRBGGGGRGBRGGGGBBBBGRRGRRBRGGBRBBBBRGGGGGGRRGRRGRRBBRBGBBGGRRGGGGRGRBGGBBGRGBGRRGGRRGRBGGBRGBRGRGGBBGGRBBRGGGGBBRGGBRRGBBRGRRBBBGRGGBGGBRBBGBBRBGGGBGBBBRBBGBBBRRBRRGRBBBBRRRGRRBRGGRRRRGRGGGBBRGBRRBBRBGGRBRGBBBBGRBRRBBGBBBRRRGBRBGBGBBGBBGRRBBRGBRGRGBGRRBBRRRGBRRGBGRGBRGGRRGRRGGBBBGGRBBBBRGRBGGGRBGGGGRRRGBBBRBGRRGBBGRGBGBGRRRGBGBRGGGGGBGGBGRBRRBRBGRGGBGRBGBBBGGGBRBGBRGGRRGBGGBBGBGRBRGBBRGBRGGGBBRGRGBRGRRRGGBBGBRRRRGRBBRRBGRRGRGGRBGGBBGGRBBBBRBGRBGGBBBBGBRGBRGGRGGGBRRRBRBGBRRGRGBGB"


# Define a function for timing
def time_triangle():
    triangle(length710)


# Measure the time
number_of_runs = 300
total_time = timeit.timeit(time_triangle, number=number_of_runs)
average_time = total_time / number_of_runs

print(f"Total time for {number_of_runs} runs: {total_time:.4f} seconds")
print(f"Average time per run: {average_time:.4f} seconds")
