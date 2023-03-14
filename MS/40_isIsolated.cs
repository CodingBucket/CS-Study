Console.WriteLine(isIsolated(64));
int isIsolated(int n)
{
    int isIsolated = 1, i = 0;
    int first = n * n, second = n * n * n;
    int secondLen = second.ToString().Length;
    int[] secondArray = new int[secondLen];
    while (second > 0) {
        int reminder = second % 10;
        if (!secondArray.Contains(reminder)) {
            secondArray[i] = reminder;
            i++;
        }
        second = second / 10;
    }
    while (first > 0) {
        int reminder = first % 10;
        if (secondArray.Contains(reminder)) {
            isIsolated = 0;
            break;
        }
        first = first / 10;
    }
    return isIsolated;
}
