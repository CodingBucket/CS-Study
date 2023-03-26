var a = new int[] { 1 };
var item = a.First();
bool isGuthrieSequence = true;

for (int i=1; i<a.Length; i++)
{
    if (item % 2 == 0)
        item = item / 2;
    else
        item = item * 3 + 1;

    if(item != a[i] || a[a.Length - 1] != 1)
    {
        isGuthrieSequence = false;
        break;
    }
}
Console.WriteLine(isGuthrieSequence);
