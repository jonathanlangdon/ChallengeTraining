# find the average of 3 scores passed in and return letter value

from statistics import mean


def get_grade(*args):
    avg = mean(args)
    if avg >= 90:
        return "A"
    if avg >= 80:
        return "B"
    if avg >= 70:
        return "C"
    if avg >= 60:
        return "D"
    return "F"


print(get_grade(92, 90, 88))  # A
print(get_grade(62, 60, 68))  # D
print(get_grade(62, 60, 23))  # F

# // a super creative solution:
# def get_grade(*s):
# return 'FFFFFFDCBAA'[sum(s)//30]
