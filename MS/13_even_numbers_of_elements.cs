var nums = new int[] { 5, 4, 3, 2, 3, 4, 6, 3};
int firstHalf = 0, secondHalf = 0;

if (nums.Length % 2 == 0)
{
    var mid = nums.Length / 2;
    for (int i=0; i<nums.Length; i++)
    {
        if (i < mid)
            firstHalf = firstHalf + nums[i];
        else
            secondHalf = secondHalf + nums[i];
    }
    if (firstHalf == secondHalf)
        Console.WriteLine(1);
    else
        Console.WriteLine(0);
}
else
    Console.WriteLine(0);

