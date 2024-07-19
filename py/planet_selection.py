# fix switch function


def get_planet_name(id):
    planet_pick = {
        1: "Mercury",
        2: "Venus",
        3: "Earth",
        4: "Mars",
        5: "Jupiter",
        6: "Saturn",
        7: "Uranus",
        8: "Neptune",
    }
    return planet_pick.get(id, "Invalid planet")


print(get_planet_name(2))  # Venus
