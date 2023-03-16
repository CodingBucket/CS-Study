
Console.WriteLine(smallest(7));

int smallest(int n)
{
    int digit = 1;
    while (digit < int.MaxValue) {
        if (hasTwo(digit))
        {
            int j = 1, min = digit, count = 1;
            while (j <= n)
            {
                j++;
                if (hasTwo(digit * j)) {
                    count++;
                    if (count == n) return min;
                }
                else break;
            }
        }
        digit++;
    }
    return n;
}

bool hasTwo(int n)
{
    while (n > 0) {
        if (n % 10 == 2)
            return true;
        n = n / 10;
    }
    return false;
}
