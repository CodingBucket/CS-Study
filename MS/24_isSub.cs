var a = new int[] { 11, 5, 3, 2 };
bool isSub = false;

for (int i=0; i<a.Length; i++)
{
    int item = a[i];
    int sum = 0;
    for (int j=i+1; j<a.Length; j++)
        sum = sum + a[j];
    if (item > sum)
        isSub = true;
    else
    {
        isSub = false;
        break;
    }
}
Console.WriteLine(isSub);
