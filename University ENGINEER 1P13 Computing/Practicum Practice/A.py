def problem1(lower, upper, step):
    for i in range(lower, upper +1, step):
        print(f'km/h:{i} \t m/h: {i*0.6214}')

def problem2(grades, average):
    weights = [0.15, 0.15, 0.3, 0.4]
    total = 0
    for i in range(4):
        total += grades[i]*weights[i]

    print(f"Final grade: {total}")
    
    if total > average:
        print("Final grade is greater than class average")
    elif total < average:
        print("Final grade is less than class average")
    else:
        print("Final grade is equal to class average")

problem1(60, 130, 10)
problem2([91, 49, 65, 89], 75)