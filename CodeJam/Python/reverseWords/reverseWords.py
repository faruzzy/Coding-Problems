#!/usr/bin/python
import os

def Main():
    output = 'output.txt'
    with open('large.in') as f:
        list = []
        next(f)
        for line in f:
            list.append( ' '.join(reversed(line.strip().split())) )
    try:
        os.remove(output)
    except OSError:
        pass

    with open(output, 'a') as f:
        for i in range(0, len(list)):
            f.write('Case #{0}: {1}\n'.format(i + 1, list[i]))


if __name__ == '__main__':
    Main()
