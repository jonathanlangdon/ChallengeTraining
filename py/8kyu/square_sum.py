def square_sum(numbers):
  sum = 0
  for el in numbers:
    sum += el ** 2
  return sum

print(square_sum([0, 3, 4, 5]))

'''
Complete the square sum function so that it squares each number passed into it and then sums the results together.

For example, for [1, 2, 2] it should return 9 because 12+22+22=91^2 + 2^2 + 2^2 = 912+22+22=9.
'''
