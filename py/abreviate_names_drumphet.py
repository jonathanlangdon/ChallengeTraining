# abbreviate names for don drumphet


def who_is_paying(name):
    if len(name) <= 2:
        return [name]
    return [name, name[:2]]


print(who_is_paying("Joseph"))  # ["Joseph", "Jo"]
print(who_is_paying("Jo"))  # ["Jo"]
print(who_is_paying(""))  # [""]
