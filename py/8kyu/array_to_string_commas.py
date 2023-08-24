# return an array as a string comma deliminated

print_array = lambda arr: ",".join(map(str, arr))

print(print_array([2, 4, 5, 2]))
