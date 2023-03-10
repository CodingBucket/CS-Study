// (1, 3) => 6, 496 => 6 + 496 = 502
// 6 = 1 + 2 + 3
Console.WriteLine(henry(1, 3));
int henry(int first, int second)
{
    int n = 1, perfectCount = 0, sum = 0;
    bool firstFound = false, secondFound = false;
    while (n < int.MaxValue)
    {
        int perfectSum = IsPerfectNumber(n);  
        if(perfectSum > 0)
        {
            perfectCount++;
            if(perfectCount == first)
            {
                firstFound = true;
                sum = sum + perfectSum;
            }
            if (perfectCount == second)
            {
                secondFound = true;
                sum = sum + perfectSum;
            }
        }
        if (firstFound && secondFound)
            break;
        n++;
    }
    return sum;
}

int IsPerfectNumber(int n)
{
    int sum = 0;
    for (int i=1; i<n; i++)
    {
        if (n % i == 0)
            sum = sum + i;
    }

    if (sum == n)
        return sum;
    else
        return 0;
}
