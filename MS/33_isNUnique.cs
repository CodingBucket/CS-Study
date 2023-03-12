var a = new[] { 1};

Console.WriteLine(isNUnique(a, 4));

int isNUnique(int[] a, int n)
{
    int count = 0;

    for (int i=0; i<a.Length; i++) {
        for (int j=i+1; j<a.Length; j++) {
            if (a[i] + a[j] == n) {
                count++;
            }
        }
    }

    return count == 1 ? 1 : 0;
}
