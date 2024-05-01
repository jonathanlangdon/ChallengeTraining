# calculate bmi given weight and height


def bmi(weight, height):
    body_mass = weight / height**2
    if body_mass <= 18.5:
        return "Underweight"
    if body_mass <= 25:
        return "Normal"
    if body_mass <= 30:
        return "Overweight"
    else:
        return "Obese"


print(bmi(50, 1.80))  # , "Underweight")
print(bmi(80, 1.80))  # , "Normal")
print(bmi(90, 1.80))  # , "Overweight")
print(bmi(110, 1.80))  # , "Obese")
print(bmi(50, 1.50))  # , "Normal")
