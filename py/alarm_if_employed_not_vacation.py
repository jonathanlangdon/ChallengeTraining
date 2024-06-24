# determine when to set an alarm


def set_alarm(employed, vacation):
    return employed and not vacation


print(set_alarm(True, True))  # False
print(set_alarm(True, False))  # True
print(set_alarm(False, True))  # False
print(set_alarm(False, False))  # False
