# replace all vowel char codes with actual letters


def is_vow(char_list):
    return [chr(n) if chr(n) in "aeiou" else n for n in char_list]


print(is_vow([100, 100, 116, 105, 117, 121]))
# [100, 100, 116, 'i', 'u', 121]

"""
other method

def is_vow(char_list):
    vowel_dict = {97: "a", 101: "e", 105: "i", 111: "o", 117: "u"}
    return list(
        map(lambda code: vowel_dict[code] if code in vowel_dict else code, char_list)
    )


"""
