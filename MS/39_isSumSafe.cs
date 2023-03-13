var a = new int[] { 5, -2, 1 };

Console.WriteLine(isSumSafe(a));

int isSumSafe(int[] a)
{
    int isSafe = 1, sum = a.Sum();
    for (int j=0; j<a.Length; j++) {
        if (a[j] == sum) {
            isSafe = 0;
            break;
        }
    }
    return isSafe;
}
