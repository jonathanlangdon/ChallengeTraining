# find index of where "needle" is in list


def find_needle(haystack):
    return f'found the needle at position {haystack.index("needle")}'


print(
    find_needle(["3", "123124234", None, "needle", "world", "hay", 2, "3", True, False])
)
# 'found the needle at position 3'
