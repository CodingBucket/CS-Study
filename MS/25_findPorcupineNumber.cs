Console.WriteLine(findPorcupineNumber(0));

int findPorcupineNumber(int a)
{
    while (a < int.MaxValue)
    {
        a++;
        if (isPrime(a) && a % 10 == 9)
        {
            int nextPrime = FindNextPrime(a + 1);
            if (nextPrime % 10 == 9)
                return a;
        }
    }
    return 0;
}

int FindNextPrime(int num)
{
    while (!isPrime(num))
        num++;
    return num;
}

bool isPrime(int n)
{
    bool isPrime = true;
    for (int i=2; i<n; i++)
    {
        if (n % i == 0) {
            isPrime = false;
            break;
        }
    }
    return isPrime;
}



