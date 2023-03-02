var a = new int[] { 11, 4, 20, 9, 2, 8 };
bool hasOdd = false, isEvenMax = false;
int[] oddArray = new int[a.Length], evenArray = new int[a.Length];
int maxValue = 0, oddIndex = 0, evenIndex = 0;

for (int i=0; i<a.Length; i++)
{
    if (a[i] % 2 != 0)
    {
        hasOdd = true;
        oddArray[oddIndex] = a[i];
        oddIndex++;
    }
    else
    {
        evenArray[evenIndex] = a[i];
        evenIndex++;
    }

    if (a[i] > maxValue)
        maxValue = a[i];
}

var evenMax = evenArray.Max();
var thirdCondition = true;

for (int i=0; i<oddIndex; i++)
{
    var odd = oddArray[i]; ;
    for (int j=0; j<evenIndex; j++)
    {
        var even = evenArray[j];
        if (odd < even && even != evenMax)
        {
            thirdCondition = false;
            break;
        }
    }
}

if (maxValue % 2 == 0)
    isEvenMax = true;

if (hasOdd && isEvenMax && thirdCondition)
    Console.WriteLine("True");
else
    Console.WriteLine("False");
