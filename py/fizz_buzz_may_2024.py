# fizz buzz solution May 2024

for i in range(1, 101):
    fizz = i % 3 == 0
    buzz = i % 5 == 0
    result = ""
    if fizz:
        result += "Fizz"
    if buzz:
        result += "Buzz"
    print(f"{result if result else i}")
