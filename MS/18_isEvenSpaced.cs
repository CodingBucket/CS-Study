var a = new int[] {100,19,131,140} ;
int max = 0, min = 0, isEvenSpaced = 0;

max = a.Max();
min = a.Min();

var diff = max - min;

if (diff % 2 == 0)
    isEvenSpaced = 1;

Console.WriteLine(isEvenSpaced);
