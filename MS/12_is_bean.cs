var nums = new int[] { 0 };
int result = 1;

for (int i=0; i<nums.Length; i++)
{
    var n = nums[i];
    var isValid = false;
    for (int j=0; j<nums.Length; j++)
    {
        if (nums[j] == n/2 || nums[j] == n*2 || nums[j] == n*2+1)
        {
            isValid = true;
            break;
        }
    }
    if (isValid == false)
    {
        result = 0;
        break;
    }
}
Console.WriteLine(result);
