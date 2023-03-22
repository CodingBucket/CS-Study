var a = new int[] { 2, 3, 1, -6, 8, -3, -1, 2 };

Console.WriteLine(nUpCount(a));
int nUpCount(int[] a)
{
    int count = 0, sum = 0, n = 5;

    for (int i = 0; i < a.Length; i++)
    {
        sum = sum + a[i];
        if (sum > n)
            count++;
    }
    return count;
}
