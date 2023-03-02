var a = new int[] {1, 4, 3, 2, 1, 2, 3, 2};
int oneCount = 0, result = 0;

for (int i=0; i<a.Length; i++)
    if (a[i] == 1) oneCount++;

for (int j = 0; j < a.Length; j++)
    if (a[j] == oneCount) result++;

Console.WriteLine(result);
