def get_score(student, home_work, exam):
    grade = round((sum(home_work)/6 * 0.4) + (0.6 * exam))
    return f"Студент, {student}, ваша підсумкова оцінка за іспит - {grade}"

def input_data():
    array = []
    name = input("student name: ")
    tuple = ()
    for i in range (1,7):
        tuple = tuple + (int(input(f"Mark number {i} ")),)
    exam = int(input("Enter exam mark: "))
    array.append(name)
    array.append(tuple)
    array.append(exam)
    return array

print(get_score(*input_data()))
