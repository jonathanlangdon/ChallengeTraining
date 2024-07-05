# reverse word order in a string


def reverse_words(s):
    word_list = s.split(" ")
    word_list.reverse()
    return " ".join(word_list)


print(reverse_words("This is great"))  # great is This

"""
another method:
return " ".join(str.split(" ")[::-1])
"""
