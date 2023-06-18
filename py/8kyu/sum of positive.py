positive_sum = lambda arr: sum(n for n in arr if n > 0)


"""
First Try:

positive_sum = lambda arr: sum(filter(lambda n: n > 0, arr))

----------------

You get an array of numbers, return the sum of all of the positives ones.

Example [1,-4,7,12] => 1 + 7 + 12 = 20

Note: if there is nothing to sum, the sum is default to 0.
"""
