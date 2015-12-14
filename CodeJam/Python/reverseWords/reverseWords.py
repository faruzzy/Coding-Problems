import os
with open('large.in') as f:
    lines = f.readlines()[1:]
    list = []
    for line in lines:
        line = line.strip()
        words = line.split()

        current = ''
        for w in reversed(words):
            current += w + ' '
        list.append(current)

try:
    if os.path.exists('output.txt'):
        os.remove('output.txt')
    with open('output.txt', 'a') as ff:
        for line in list:
            ff.write(line)
            ff.write('\n')
except OSError:
    pass

