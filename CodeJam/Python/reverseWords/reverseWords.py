import os

output = 'output.txt'
with open('large.in') as f:
    list = []
    next(f)
    for line in f:
        list.append(' '.join(reversed(line.split())))
try:
    os.remove('output.txt')
    with open('output.txt', 'a') as f:
        for line in list:
            f.write(line)
            f.write('\n')
except OSError:
    pass

