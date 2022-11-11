# Algorithm
# The brute force approach is simple. Loop through each element xx and 
# find if there is another value that equals to target - xtarget−x.

nums = [2, 7, 19, 11]
target = 9

for i in range(len(nums)):
    for j in range(i+1, len(nums)):
        if nums[i] + nums[j] == target:
             return [i, j]
