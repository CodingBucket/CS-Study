var a = new int[] { 3, 3, 3, 2, 2, 0, 1, 1};

Console.WriteLine(clusterCompression(a));

int[] clusterCompression(int[] a)
{
    var clusterList = new List<int>();
    int i = 0;
    while (i < a.Length)
    {
        int j = i + 1;

        while (j < a.Length && a[j] == a[i])
        {
            j++;
        }

        clusterList.Add(a[i]);
        i = j;
    }
    return clusterList.ToArray();
}




