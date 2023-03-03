var a = new int[] { 2, 7, 8, 9, 11, 13, 10 };
int mid = a.Length / 2;
bool isSym = true;
int rightIndex = a.Length - 1;

for (int i=0; i<mid; i++)
{
    int leftItem = a[i];
    int rightItem = a[rightIndex];
    if ((leftItem % 2 == 0 && rightItem % 2 == 0) ||
        (leftItem % 2 != 0 && rightItem % 2 != 0))
    {
        rightIndex--;
    }
    else
    {
        isSym = false;
        break;
    }
}
Console.WriteLine(isSym);
