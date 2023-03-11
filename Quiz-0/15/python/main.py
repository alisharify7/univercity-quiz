import os, sys


def main():
    # by default input always return a String 
    n = input("Enter a Number: ")
    # but for solving this question we can
    # use also str function to convert input to str

    # make sure user enter a number
    if n.isdigit():
        print(n)
    else:
        print(n, " - is not a Number")

if __name__ == "__main__":
    main()