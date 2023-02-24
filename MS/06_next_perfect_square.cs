var number = 6;
int nextPerfectSquare = 0;

if (number >= 0)
{
    var sqrtResult = Math.Sqrt(number);
    int next = (int)sqrtResult + 1;
    nextPerfectSquare = (int)Math.Pow(next, 2);
}

Console.WriteLine(nextPerfectSquare);
