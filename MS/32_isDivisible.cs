var a = new int[] { };

Console.WriteLine(isDivisible(a, 12));

int isDivisible(int[] a, int n)
{
    int isDivisible = 1;
    for (int i=0; i<a.Length; i++) {
        if (a[i] % n != 0) {
            isDivisible = 0;
            break;
        }
    }
    return isDivisible;
}
