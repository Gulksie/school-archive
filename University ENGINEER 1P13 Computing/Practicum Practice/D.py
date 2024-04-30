def problem1(matrix):return sum(x := [num for row in matrix for num in row])/len(x)

def problem2(money, prices):
    prices = sorted(prices)
    count = 0

    for i in prices:
        money -= i
        count += 1

        if money <= 0:
            count -= 1
            break

    return count

print(problem1([[4,2,5],[7,5,8],[5,8,4],[10,30,3]]))

print(problem2(10.99, [5.10, 1.22, 3.99, 4.00,6.00]))