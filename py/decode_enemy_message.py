# encoding & decoding secret messages

letter_list = [
    "a",
    "b",
    "c",
    "d",
    "e",
    "f",
    "g",
    "h",
    "i",
    "j",
    "k",
    "l",
    "m",
    "n",
    "o",
    "p",
    "q",
    "r",
    "s",
    "t",
    "u",
    "v",
    "w",
    "x",
    "y",
    "z",
    "A",
    "B",
    "C",
    "D",
    "E",
    "F",
    "G",
    "H",
    "I",
    "J",
    "K",
    "L",
    "M",
    "N",
    "O",
    "P",
    "Q",
    "R",
    "S",
    "T",
    "U",
    "V",
    "W",
    "X",
    "Y",
    "Z",
    "0",
    "1",
    "2",
    "3",
    "4",
    "5",
    "6",
    "7",
    "8",
    "9",
    ".",
    ",",
    "?",
    " ",
]


def encode(string):
    encoded_string = ""
    for string_index, char in enumerate(string):
        if char not in letter_list:
            encoded_string += char
            continue
        coded_index = ((letter_list.index(char) + 1) * 2 ** (string_index + 1)) % 67 - 1
        encoded_string += letter_list[coded_index]
    return encoded_string


def decode(s):
    decoded_string = ""
    for string_index, char in enumerate(s):
        if char not in letter_list:
            decoded_string += char
            continue
        decode_index = (
            (letter_list.index(char) + 1) * pow(2, -1 * (string_index + 1), 67) - 1
        ) % 67
        decoded_string += letter_list[decode_index]
    return decoded_string
