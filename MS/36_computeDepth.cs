Console.WriteLine(computeDepth(25));
int computeDepth(int n)
{
    int depth = 0, digitCount = 0; bool gotZero = false;
    var digits = new int[10];
    for (int i = 1; digitCount <= 10; i++)
    {
        int multi = n * i;
        while (multi > 0)
        {
            int reminder = multi % 10;
            if (reminder == 0 && gotZero == false) {
                gotZero = true;
                digitCount++;
            }
            if (!digits.Contains(reminder)) {
                digits[digitCount] = reminder;
                digitCount++;
            }
            multi = multi / 10;
        }
        depth++;
        if (digitCount == 10)
            break;
    }
    return depth;
}
