var a = new int[] { 22, 19, 10, 10, 19, 22, 22, 10 };

Console.WriteLine(isTrivalent(a));

int isTrivalent(int[] a)
{
    int isTrivalent = 0, count = 0; var digitArray = new int[a.Length];
    bool gotZero = false;

    for (int i=0; i<a.Length; i++) {
        if (!gotZero && a[i] == 0) {
            gotZero = true;
            count++;
        }
        if (!digitArray.Contains(a[i])) {
            digitArray[count] = a[i];
            count++;
        }
    }

    if (count == 3)
        isTrivalent = 1;

    return isTrivalent;
}
