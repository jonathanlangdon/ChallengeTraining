# check for valid input then sum up grades

def sum_up_grades(grades):
    grade_int_list = [int(grade) for grade in grades.split(",")]
    if has_bad_grade_value(grade_int_list):
        return "All values need to be greater than 0 but less than 100"
    if has_bad_total(grade_int_list):
        return "One of the grades is wrong, total needs to be less than 100!"
    return sum(grade_int_list)
    
def has_bad_grade_value(grade_values):
    for grade in grade_values:
        if grade > 100 or grade < 0:
            return True
    return False
    
def has_bad_total(grade_values):
    if sum(grade_values) > 100:
        return True
    return False

if __name__ == '__main__':
    print(sum_up_grades(input()))
