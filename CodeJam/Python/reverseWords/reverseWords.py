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
        for i in range(0, len(list)):
            f.write('Case #{0}: {1}\n'.format(i+1, list[i]))
except OSError:
    pass

