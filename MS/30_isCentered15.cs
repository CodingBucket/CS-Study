var a = new int[] { 1, 1, 15, -1, -1};

Console.WriteLine(isCentered15(a));

int isCentered15(int[] a) {
    int start = 1, end = a.Length - 2, isCentered = 0, mid;
    if (a.Length % 2 == 0)
        mid = a.Length / 2;
    else
        mid = a.Length / 2 + 1;
    while (start <= mid) {
        int sum = 0;
        for (int i=start; i<=end; i++) {
            sum = sum + a[i];
        }
        if (sum == 15)
        {
            isCentered = 1;
            break;
        }
        start++; end--;
    }
    return isCentered;
}
