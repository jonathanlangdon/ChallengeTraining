# calculate tip based on text rating

import math


def calculate_tip(amount, rating):
    rating_lower = rating.lower()
    if rating_lower in rating_percents:
        return math.ceil(rating_percents[rating_lower] * amount)
    return "Rating not recognised"


rating_percents = {
    "terrible": 0,
    "poor": 0.05,
    "good": 0.1,
    "great": 0.15,
    "excellent": 0.2,
}

print(calculate_tip(10, "poOr"))  # 1
print(calculate_tip(14, "Good"))  # 2
print(calculate_tip(14, "alright"))  # "Rating not recognised"
