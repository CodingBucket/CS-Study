var a = new int[] { 5, 5, 5, 2, 5 };

Console.WriteLine(isSequentiallyBounded(a));

int isSequentiallyBounded(int[] a)
{
    int isSequence = 1;
    for (int i=0; i<a.Length; i++)
    {
        int count = 1;
        for (int j=i+1; j<a.Length; j++)
        {
            if (a[i] > a[j] || count >= a[i])
                return 0;
            if (a[i] == a[j])
                count++;
        }
    }
    return isSequence;
}
