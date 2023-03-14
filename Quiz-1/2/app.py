import os,sys


def main():

    n = input("Enter n: ")
    try:
        n = int(n)
    except ValueError :
        sys.exit("Invalid input")
    
    reverse = 0
    while n != 0:
        last = n % 10
        reverse = (reverse * 10) + last
        n = n // 10 

    print(reverse)



if __name__ == "__main__":
    main()