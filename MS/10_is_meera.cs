var nums = new int[] { 6, 10, 8 };
bool hasOne = false, hasNine = true;

for (int i=0; i<nums.Length; i++)
{
    if (nums[i] == 1)
        hasOne = true;
    else if (nums[i] == 9)
        hasNine = true;
}

int result = hasOne && hasNine ? 1 : 0;

Console.WriteLine(result);
