Console.WriteLine(getExponent(128, 4));

int getExponent(int n, int p)
{
    if (p <= 1) return -1;

    int x = 0;

    while (true)
    {
        var pow = Math.Pow(p, x);
        if (n % pow != 0) break;
        x++;
    }

    return x - 1;
}
