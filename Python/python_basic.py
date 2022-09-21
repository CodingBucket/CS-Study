# List comprehensions are an elegant way to build a list without having to use different for loops to append values one by one.
list_com = [x for x in range(10) if x % 3 == 0]  # Output => [0, 3, 6, 9]

# Print 2 digit after point
print("%.2f" % 10)

# string list to int list
nums = ['1', '2', '3']
n_list = list(map(int, nums))  # [1, 2, 3]
n_list = [int(item) for item in nums] # [1, 2, 3]

# In Python 3 you can iterate over the lines of standard input, the loop will stop when EOF is reached:
from sys import stdin

for line in stdin:
  print(line, end='')



