#!/usr/bin/python
def main():
    print(reverseFactorial(120))
    print(reverseFactorial(3628800))
    print(reverseFactorial(479001600))
    print(reverseFactorial(6))
    print(reverseFactorial(18))
    print(reverseFactorial(16))

def reverseFactorial(val):
    curr = val
    i = 2

    while curr % i == 0:
        result = curr / i
        if result != 1:
            i += 1
            curr = result
        else:
            return '{0} = {1}'.format(val, curr)
    return 'None'

if __name__ == '__main__':
    main()
