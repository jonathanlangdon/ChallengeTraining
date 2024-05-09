# turn digits 0-4 with 0 and 5-9 with 1

import re


def fake_bin(str):
    replacedZeros = re.sub(r"[0-4]", "0", str)
    return re.sub(r"[5-9]", "1", replacedZeros)


print(fake_bin("150827"))  # 010101

# A more concise way:
# def fake_bin(s):
#   return ''.join('0' if int(c) < 5 else '1' for c in s)
