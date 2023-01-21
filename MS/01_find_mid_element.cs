var nums = new int[] { 1, 2, 3, 4, 5 };
var numsLength = nums.Length;
var result = 1;

if (numsLength == 0 || numsLength % 2 == 0)
    result = 0;

int midIndex = numsLength / 2;

for (var i=0; i<numsLength; i++)
{
    if (i == midIndex)
        continue;
    if (nums[i] < nums[midIndex])
    {
        result = 0;
        break;
    }
}

Console.WriteLine(result);
