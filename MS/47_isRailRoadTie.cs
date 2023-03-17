var a = new int[] { 1, 2, 0, 3, -18, 0, 2, 2 };

Console.WriteLine(isRailRoadTie(a));

int isRailRoadTie(int[] a)
{
    int isValid = 1;

    if (a.Length == 1) return 0;

    for (int i=0; i<a.Length; i++) {
        if (a[i] != 0) isValid = 1;

        if (a[i] == 0)
        {
            if (i == 0 || i == a.Length - 1 || a[i - 1] == 0 || a[i + 1] == 0)
                return 0;

        }
        else
        {
            if ((i == 0 && a[i + 1] == 0) || (i == a.Length - 1 && a[i - 1] == 0) || (i > 0 && i < a.Length - 1 && a[i - 1] == 0 && a[i + 1] == 0))
                return 0;
        }

    }

    return isValid;
}




