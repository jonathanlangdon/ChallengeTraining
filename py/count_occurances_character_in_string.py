# count how many occurances of a character in a string

str_count = lambda strng, letter: strng.count(letter)


print(str_count("", 'z')) # 0
print(str_count("Ozzie", 'z')) # 2
print(str_count("The great Oz", 'z')) # 1