# determine if you will make it on gallons of gas or not


def zero_fuel(dist_to_pump, mpg, fuel_left):
    return fuel_left >= dist_to_pump / mpg


print(zero_fuel(3, 3, 1))  # true
print(zero_fuel(3, 2, 1))  # false
