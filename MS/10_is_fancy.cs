int number = 60, isFancy = 0, previous = 1, pPrevious = 1;

if(number == 1) Console.WriteLine("Fancy");

if (number <= 0) Console.WriteLine("Not");

for (int i = 1; i < number; i++)
{
    int currentNumber = 3 * previous + 2 * pPrevious;
    if (currentNumber == number)
    {
        isFancy = 1;
        break;
    }
    else
    {
        isFancy = 0;
        pPrevious = previous;
        previous = currentNumber;
    }
}
Console.WriteLine(isFancy);
