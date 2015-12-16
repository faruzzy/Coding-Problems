import os, sys

def main():
    output = 'output.txt'
    res_list = []
    with open('large.in') as f:
        lines = [ line.strip() for line in f.readlines() ][1:]
        for i in range(0, len(lines), 3):
            list = lines[i:i+3]
            items = [int(n) for n in list[2].split(' ')]
            total = int(list[0])

            for j in range(len(items)):
                needle = total - items[j]
                index = index_of(needle, items, j + 1)
                if index != -1:
                    res_list.append([j, index])
                    break
    try:
        os.remove(output)
        with open(output, 'a') as f:
            for j in range(len(res_list)):
                f.write('Case #{0}: {1} {2}\n'.format(j + 1, res_list[j][0], res_list[j][1]))
    except OSError:
        pass

def test():
    my_list = [int(n) for n in '2 1 9 4 4 56 90 3'.split(' ')]
    print('index = {0}'.format(index_of(4, my_list, 5)))
    print('index = {0}'.format(index_of(14, my_list, 12)))

def index_of(element, list_element, start = 0):
    length = len(list_element)
    if length == 0:
        return -1

    if start < length:
        counter = 0
        for i in range(length):
            if counter < start:
                counter += 1
                continue

            if list_element[i] == element:
                return i;
        return -1
    else:
        sys.exit("Starting index is above length of the list")

if __name__ == '__main__':
    main()
    #test()

