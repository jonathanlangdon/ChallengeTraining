# reverse the words in a string


def reverse(string):
    return " ".join(string.split()[::-1])


print(reverse("Hello World"))
