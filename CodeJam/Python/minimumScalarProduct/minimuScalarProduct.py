#!/usr/bin/python

def main():
    def indexOfSmallest(list):
        value = min(list)
        return list.index(value)

    def indexOfLargest(list):
        value = max(list)
        return list.index(value)

    with open('large.txt') as f:
        lines = [ line.strip() for line in f.readlines()[1:] ]
        total_list = []
        for i in range(0, len(lines), 3):
            total = 0
            x = [ int(item) for item in lines[i + 1].split(' ') ]
            y = [ int(item) for item in lines[i + 2].split(' ') ]

            while len(x) > 0:
                xSmallest = min(x)
                if xSmallest < 0:
                    total += min(x) * max(y)
                    del x[indexOfSmallest(x)]
                    del y[indexOfLargest(y)]
                else:
                    total += max(x) * min(y)
                    del x[indexOfLargest(x)]
                    del y[indexOfSmallest(y)]
            total_list.append(total)

    with open('output.in', 'a') as f:
        for i in range(len(total_list)):
            f.write('Case #{0}: {1}\n'.format(i + 1, total_list[i]))

if __name__ == '__main__':
    main()