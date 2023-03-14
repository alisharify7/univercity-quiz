import os,sys


def main():

    n = input("Enter n: ")
    try:
        n = int(n)
    except ValueError :
        sys.exit("Invalid input")
    
    res =1
    for i in range(1,n+1):
        res *= i

    print(f"Factorial of {n} is {res}")



if __name__ == "__main__":
    main()