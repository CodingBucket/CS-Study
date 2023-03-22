var a = new int[] { 1, 8, 3, 7, 10, 2 };
int leftP = 0, rightP = a.Length - 1, idx = 1;
int leftSum = a[leftP], rightSum = a[rightP];
if (a.Length < 3)
    Console.WriteLine(-1);

for (int i=1; i<a.Length -2; i++)
{
    if (leftSum < rightSum)
    {
        leftP++;
        leftSum = leftSum + a[leftP];
        idx = leftP + 1;
    }
    else
    {
        rightP--;
        rightSum = rightSum + a[rightP];
        idx = rightP - 1;
    }
}
if (leftSum == rightSum)
    Console.WriteLine(idx);
else
    Console.WriteLine(-1);
