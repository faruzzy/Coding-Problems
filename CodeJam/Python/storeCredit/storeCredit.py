#!/usr/bin/python
import os, sys

def Main():
    output = 'output.txt'
    res_list = []
    with open('large.in') as f:
        lines = [ line.strip() for line in f.readlines() ][1:]
        for i in range(0, len(lines), 3):
            current_list = lines[i:i+3]
            items = [ int(n) for n in current_list[2].split(' ') ]
            total = int(current_list[0])

            for j in range(len(items)):
                needle = total - items[j]
                index = index_of(needle, items, j + 1)
                if index != -1:
                    res_list.append([j, index])
                    break
    try:
        os.remove(output)
        with open(output, 'w+') as f:
            for j in range(len(res_list)):
                f.write('Case #{0}: {1} {2}\n'.format(j + 1, res_list[j][0], res_list[j][1]))
    except OSError:
        pass

def test():
    my_list = [int(n) for n in '2 1 9 4 4 56 90 3'.split(' ')]
    print('index = {0}'.format(index_of(4, my_list, 1)))
    print('index = {0}'.format(index_of(3, my_list, 0)))

def index_of(element, list_element, start=0):
    try:
        if start < len(list_element):
            index = list_element.index(element, start)
            return index
        else:
            sys.exit('Starting index is above length of the list')
    except ValueError:
        return -1

if __name__ == '__main__':
    Main()
    #test()

