int start = -10, end = 6, count = 0;

if (start > end) Console.WriteLine("0");

for (int i = start; i <= end; i++)
{
    if (i > 1)
    {
        var isPrime = true;
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
            count++;
    }
}
Console.WriteLine(count);
