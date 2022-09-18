from array import array


def show_tuple(tuple, num = None):
    if num == None:
        print(f"Club: {tuple[0]}\nPoints:{tuple[1]}\n"+"Winner of world championship" if tuple[2] == True else "-\n" + f"Captain name  {tuple[3]}")
    else:
        try:
            print(tuple[num])
        except:
            print("False number")

def input_tuple():
    array = []
    num = int(input("Enter number of teams: "))
    for i in range(num):
        name = input("enter club name: ")
        points = int(input("enter number of points: "))
        is_winner = True if input("Is world champion [YES/NO]: ").lower() == "yes" else False
        cap_name = input("enter name of captain: ")
        tupl = (name, points, is_winner, cap_name)
        array.append(tupl)
    return array

def task(array:array):
    sum = 0
    res = []
    num = 0
    for tuple in array:
        sum += tuple[1]
    avg = sum / len(array)

    for tuple in array:
        if(tuple[1] > avg):
            res.append(tuple)
            num += 1
    return (num, res)

if __name__ == "__main__":
    print(task(input_tuple())[0])