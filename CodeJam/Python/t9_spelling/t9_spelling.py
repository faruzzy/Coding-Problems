#!/usr/bin/python
import os

def main():
    pad = {
        '2': ['a', 'b', 'c'],
        '3': ['d', 'e', 'f'],
        '4': ['g', 'h', 'i'],
        '5': ['j', 'k', 'l'],
        '6': ['m', 'n', 'o'],
        '7': ['p', 'q', 'r', 's'],
        '8': ['t', 'u', 'v'],
        '9': ['w', 'x', 'y', 'z']
    }

    result_list = []
    with open('large.in') as f:
        lines = [n.strip() for n in f.readlines()][1:]
        for line in lines:
            token = [c for c in line]
            result = ''
            last = ''
            for t in token:
                if t == ' ':
                    result += '0'
                    continue

                for k, value in pad.items():
                    if t in value:
                        if k == last:
                            result += ' '
                        for i in range(value.index(t) + 1):
                            result += k
                        last = k
                        break
            result_list.append(result)

    try:
        os.remove('output.txt')
    except OSError:
        pass

    with open('output.txt', 'a') as f:
        for k in range(len(result_list)):
            f.write('Case #{0}: {1}\n'.format(k + 1, result_list[k]))

if __name__ == '__main__':
    main()
