# FizzBuzz Challenge using recursive function


def fizzBuzz(num):
    if num > 100:
        return
    result = ""
    if num % 3 == 0:
        result += "Fizz"
    if num % 5 == 0:
        result += "Buzz"
    if result == "":
        result = num
    print(result)
    fizzBuzz(num + 1)


fizzBuzz(1)
