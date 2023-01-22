var n = new int[] {1, 3, 7, 9};
var n1 = new int[] { 7, 1, 9, 3};
var j = 0;
var count = 0;
var minLen = n.Length < n1.Length ? n.Length : n1.Length;
var r = new int[minLen];

if (n == null || n1 == null)
    Console.WriteLine("null");

foreach (var i in n)
{
    if (n1.Contains(i))
    {
        r[j] = i;
        count++;
        j++;
    }
}

var re = new int[count];
for (var i=0; i<count; i++)
    re[i] = r[i];

foreach (var i in re)
    Console.WriteLine(i);
