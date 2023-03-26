var a = new int[] { 0,0,0 };
int sum = 0, count = 0;

for (int i = 0; i < a.Length; i++)
    sum = sum + a[i];

for (int j = 0; j < a.Length; j++)
    if (a[j] == sum) count++;

Console.WriteLine(count);
