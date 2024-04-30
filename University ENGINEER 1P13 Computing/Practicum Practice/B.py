def problem1(rows, columns):print(('*'*columns + '\n')*rows)

def problem2(hours, wage):
    gross = []
    for i in hours:
        total = i * wage

        if i > 40:
            total += (i-40)*0.5*wage

        gross.append(total)

    return gross

problem1(4, 7)
print(problem2([35, 48, 37, 42, 21, 60], 25))