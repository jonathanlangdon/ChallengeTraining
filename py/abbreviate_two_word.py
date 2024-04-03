# convert a first/last name into initials


def abbrev_name(name):
    list = name.upper().split(" ")
    return f"{list[0][0]}.{list[1][0]}"


print(abbrev_name("Sam harris"))

"""
Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

The output should be two capital letters with a dot separating them.

It should look like this:

Sam Harris => S.H

patrick feeney => P.F

"""
