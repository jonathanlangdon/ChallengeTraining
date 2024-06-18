# determine next color of traffic light


def update_light(current):
    next_light = {"green": "yellow", "yellow": "red", "red": "green"}
    return next_light[current]


print(update_light("red"))  # green
