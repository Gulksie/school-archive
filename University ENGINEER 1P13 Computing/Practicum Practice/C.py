def problem1(n):
    total = 0
    for i in range(n):
        total += (i+1)/(n-i)
    return total

def problem2(items):
    total = 0
    for i in items:
        toAdd = i*99

        if i > 100:
            toAdd *= 0.3
        elif i > 50:
            toAdd *= 0.2
        elif i > 10:
            toAdd *= 0.1
        else:
            toAdd = 0

        total += toAdd

    return total
    

print(problem1(20))
print(problem2([5, 12, 51, 120]))