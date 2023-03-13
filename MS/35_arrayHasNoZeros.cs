var a = new int[] { 1, 2, 3, 0};

Console.WriteLine(arrayHasNoZeros(a));
int arrayHasNoZeros(int[] a)
{
    int hasNoZero = 1;
    for (int i=0; i<a.Length; i++)
    {
        if (a[i] == 0)
        {
            hasNoZero = 0;
            break;
        }
    }
    return hasNoZero;
}
