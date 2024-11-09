# return the first non-consecutive number


def first_non_consecutive(arr):
    for num in range(1, len(arr)):
        if arr[num] != arr[num - 1] + 1:
            return arr[num]
    return None
