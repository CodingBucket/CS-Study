var nums = new int[] { 1, 2, 3, 4, 5 };

var oddSum = 0;
var evenSum = 0;

foreach (var i in nums)
{
    if (i % 2 == 0)
        evenSum = evenSum + i;
    else
        oddSum = oddSum + i;
}

Console.WriteLine(oddSum - evenSum);
