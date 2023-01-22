def calculate(n):
    first = 0
    second = 1
    print(first)
    print(second)
    for i in range(1, n):
        third = first + second
        print(third)
        first, second = second, third

n = int(input("Enter nth term: "))
calculate(n)