# return whether a person plays the banjo


def are_you_playing_banjo(name):
    return f'{name} {"plays" if name[0].lower() == "r" else "does not play"} banjo'


print(are_you_playing_banjo("Roger"))
# Roger plays banjo
print(are_you_playing_banjo("roger"))
# roger plays banjo
print(are_you_playing_banjo("Doger"))
# Doger does not play banjo
