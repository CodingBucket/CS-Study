var a = new int[] { 9};
int count = 0;
for (int i=0; i<a.Length; i++)
{
    for (int j=0; j<a.Length; j++)
    {
        if (a[j] != a[i] && a[i] > 0 && a[j] > 0 && isSqrtRoot(a[i] + a[j]))
        {
            if (a[j] > a[i]) count++;
        }
    }
}
Console.WriteLine(count);

bool isSqrtRoot(int n)
{
    var result = Math.Sqrt(n);
    if (result == (int)result)
        return true;
    else
        return false;
}
