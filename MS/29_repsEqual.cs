var a = new int[] { 0, 3, 2, 0, 5, 3};

Console.WriteLine(repsEqual(a, 32053));

int repsEqual(int[] a, int n)
{
    for (int i=a.Length-1; i>0; i--) {
        int lastDigit = n % 10;
        if (a[i] != lastDigit) {
            return 0;
        }
        n = n / 10;
    }
    return 1;
}
