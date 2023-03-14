import os,sys


def main():
    grades = []
    
    for i in range(100):
        grade = input("Enter Grade: ")
        try:
            grade = int(grade)
        except ValueError :
            sys.exit("Invalid input")
        if grade > 15:
            grades.append(grade)
    
    print(sum(grades) / len(grades))




if __name__ == "__main__":
    main()