var nums = new int[] { 1, 2, 3, 4 , 88, 56, 90, 35, 74};
int max = 0, prevMax = 0;

for (var i = 0; i<nums.Length; i++)
{
    if (nums[i] > max)
    {
        prevMax = max;
        max = nums[i];
    }
}
Console.WriteLine(prevMax);
