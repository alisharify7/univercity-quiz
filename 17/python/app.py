import os, sys
from tabulate import tabulate

def calculate_divided(n):
    """  this function take an number and return number of divided of that number """
    """  For example: input(5) => calculate(1,5) => return(2)  """
    div_number = 1
    numbers = []
    for each in range(1, int(n/2) + 1):
        if n % each == 0:
            numbers.append(each)   
            div_number += 1
    
    return [div_number, numbers]


top_10 = [
    [0,0],
    [0,0],
    [0,0],
    [0,0],
    [0,0],
    [0,0],
    [0,0],
    [0,0],
    [0,0],
    [0,0],
]

def check_top_10(dt,number_of_div):
    for index,each in enumerate(top_10):
        if top_10[index][1] > number_of_div:
            continue
        else:
            top_10[index][0] = dt
            top_10[index][1] = number_of_div
            return 

def main():
    for i in range(1,10_001):
        check_top_10(i, calculate_divided(i)[0])
        print(f"{i} = [{calculate_divided(i)[-1]}]")
    print("*" * 35)
    print("TOP 10 Numbers with bigest divided Numbers is:")
    print(tabulate(top_10, tablefmt="grid")) 



if __name__ == "__main__":
    main()