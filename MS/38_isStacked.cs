Console.WriteLine(isStacked(15));

int isStacked(int n)
{
    int isStacked = 0, sum = 0;
    for (int i=1; i<=n; i++) {
        sum = sum + i;
        if (sum == n) {
            isStacked = 1;
            break;
        }
    }
    return isStacked;
}
