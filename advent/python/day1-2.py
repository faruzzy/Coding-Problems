def main():
    counter = 0
    with open('input1-1.in') as f:
        chars = [ char for char in f.readline() ]
        for i in xrange(len(chars)):
            if chars[i] == '(':
                counter += 1
            else:
                counter -= 1
            if counter < 0:
                return i

if __name__ == '__main__':
    print(main())