# Remove duplicates from list

def distinct(seq):
  unique = []
  [unique.append(item) for item in seq if item not in unique]
  return unique

''' Define a function that removes duplicates from an list of numbers and returns it as a result.

The order of the sequence has to stay the same.
'''
