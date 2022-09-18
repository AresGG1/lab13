from random import randint, random, shuffle
from collections import namedtuple

surnames = ["Ivanchuk", "Trufyn", "Stoliv", "Stetsyk", "Palamar", "Fesin", "Melnychuk", "Holubiv", "Karas", "Pavliv", "Romanko"]
specialities = ["IPZ", "History and archeology", "Math", "Biology", "Law", "Linguists", "Economists"]

Student = namedtuple("Student", ["surname", "avg_mark", "spetiality", "course"])

def show(tup):
    for i in tup:
        print(f"surname: {i.surname}, average mark: {i.avg_mark}, spetiality: {i.spetiality}, course: {i.course}")
    print("----------------------------")


def bursary(tup):
    new_tup = ()
    sum = 0
    for i in tup:
        sum += i.avg_mark
    avg = sum / len(tup)
    for i in tup: 
        if i.avg_mark < avg:
            new_tup = new_tup + (i,)
    show(new_tup)

    return new_tup

def input_tuple():
    tupl = ()
    for i in range(1,8):
        surname = input("Enter surname: ")
        avg_mark = float(input("Enter average mark: "))
        spetiality = input("Enter spetiality: ")
        course = input("Enter course: ")
        student = Student(surname, avg_mark, spetiality, course)
        tupl + (student)
    return tupl

def random_input():
    tupl = ()
    global surnames
    global specialities
    shuffle(surnames)
    shuffle(specialities)

    for i in range(1,8):
        surname = surnames.pop()
        avg_mark = round(randint(50,99) + random(), 1)
        spetiality = specialities.pop()
        course = randint(1,6)
        student = Student(surname, avg_mark, spetiality, course)
        tupl = tupl + (student,)
    return tupl

def replace(tupl):
    new_tuple = ()
    for student in tupl:
        avg_mark = round(randint(50,99) + random(), 1)
        student = student._replace(avg_mark = avg_mark)
        new_tuple = new_tuple + (student, )
    return new_tuple

if __name__ == "__main__":
    tupl = random_input()
    show(tupl)
    bursary(tupl)
    tupl = replace(tupl)
    show(tupl)
    bursary(tupl)
    