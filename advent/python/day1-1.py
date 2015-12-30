def main():
    counter = 0
    with open('day1-1.in') as f:
        for char in f.readline():
            if char == '(':
                counter += 1
            else:
                counter -= 1
    return counter

if __name__ == '__main__':
    print(main())