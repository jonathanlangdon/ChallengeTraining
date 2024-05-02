# return [count of positives, sum of negatives]


def count_positives_sum_negatives(arr):
    positive_count = list(map(lambda x: x > 0, arr)).count(True)
    negative_sum = sum(map(lambda x: x if x < 0 else 0, arr))
    if not arr:
        return []
    return [positive_count, negative_sum]


print(count_positives_sum_negatives([1, 2, 5, -3, -2, -1, 0]))  # 3, -6
print(count_positives_sum_negatives([0, 0]))  # [0, 0]
print(count_positives_sum_negatives([]))  # []
