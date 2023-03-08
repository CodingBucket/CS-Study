var a = new int[] { 3, 1, 2, 3, 0 };

Console.WriteLine(IsMadhavArray(a));

int IsMadhavArray(int[] a)
{
    int start = 1, end = 2, count = 2, first = a[0], result = 1;
    while (end < a.Length) {
        int sum = 0;
        for (int i=start; i<=end; i++) {
            sum = sum + a[i];
        }
        if (sum != first) {
            result = 0;
            break;
        }
        count++;
        start = end + 1;
        end = end + count;
    }
    return result;
}
