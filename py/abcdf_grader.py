# autograder for inputed grade


def grader(score):
    return (
        "F"
        if score > 1
        else (
            "A"
            if score >= 0.9
            else (
                "B"
                if score >= 0.8
                else "C" if score >= 0.7 else "D" if score >= 0.6 else "F"
            )
        )
    )


print(grader(0.8))  # B
print(grader(0.799))  # C
print(grader(0.599))  # F
print(grader(0.999))  # A
print(grader(1.01))  # F
print(grader(0))  # F
