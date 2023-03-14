import sys

def main():
    n = input("Enter a Number: ")
    try:
        n = int(n)
    except ValueError:
        sys.exit("Input Must be Integer")

    res = 1
    for i in range(1,n+1):
        res *= i
        if res > n:
            sys.exit("Not Found")

        if res == n:
            sys.exit(f"{i} != {res}")


if __name__ == '__main__':
    main()
