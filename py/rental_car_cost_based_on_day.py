# determine rental car costs


def rental_car_cost(days):
    if days >= 7:
        return days * 40 - 50
    if days >= 3:
        return days * 40 - 20
    return days * 40


print(rental_car_cost(7))  # 230
print(rental_car_cost(3))  # 100
print(rental_car_cost(2))  # 80
