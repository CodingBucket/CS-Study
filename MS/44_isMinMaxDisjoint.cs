var a = new int[] { 5, 4, 1, 3, 2 };

Console.WriteLine(isMinMaxDisjoint(a));

int isMinMaxDisjoint(int[] a)
{
    int isValid = 1, maxCount = 0, minCount = 0, maxIndex = 0, minIndex = 0;
    int max = a.Max(), min = a.Min();

    for (int i=0; i<a.Length; i++) {
        if (a[i] == max) {
            maxCount++;
            maxIndex = i;
        }
        if (a[i] == min) {
            minCount++;
            minIndex = i;
        }
    }

    int diff = Math.Abs(maxIndex - minIndex);
    if (max == min || maxCount > 1 || minCount > 1 || diff == 1) {
        isValid = 0;
    }

    return isValid;
}
