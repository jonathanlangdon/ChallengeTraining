# return number 0-9 in words: 1-> "One" etc.


def switch_it_up(number):
    num_dict = {
        0: "Zero",
        1: "One",
        2: "Two",
        3: "Three",
        4: "Four",
        5: "Five",
        6: "Six",
        7: "Seven",
        8: "Eight",
        9: "Nine",
    }
    try:
        return num_dict[number]
    except:
        return "Unknown value"


print(switch_it_up(1))  # "One"
print(switch_it_up(9))  # "Nine"
print(switch_it_up(11))  # "Unknown"
