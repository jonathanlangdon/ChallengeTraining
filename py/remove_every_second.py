# remove every 2nd element from a list

def remove_every_other(my_list):
    new_list = []
    for i in range(0, len(my_list)):
        if (i % 2 == 0): new_list.append(my_list[i])
    return new_list

print(remove_every_other([1, 2, 3, 4])) # 1, 3
print(remove_every_other(['Hello', 'Goodbye', 'Hello Again'])) # ['Hello', 'Hello Again']

'''
Better Method:

def remove_every_other(my_list):
    return my_list[::2]

'''