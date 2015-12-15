# Add up all number until they're are
# a single digit

#recursively
def answer(x=0):
    if len(str(x)) == 1:
        return x
    return answer(sum([int(n) for n in str(x)]))

#iteratively
def loopSum(x=0):
    while (len(str(x)) != 1):
        x = sum([int(n) for n in str(x)])
    return x
