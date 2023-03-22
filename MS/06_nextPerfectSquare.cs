var number = 6;
int nextPerfectSquare = 0;

if (number >= 0)
{
    var sqrtResult = Math.Sqrt(number);
    int next = (int)sqrtResult + 1;
    nextPerfectSquare = (int)Math.Pow(next, 2);
}

Console.WriteLine(nextPerfectSquare);


// Second Solution
int Solution(int n) 
{
    int result = 0; int i = 0;

    while (i <= n+1) {
        int square = i * i;
        if (square > n)
            return square;
        i++;
    }
    return result;
}
