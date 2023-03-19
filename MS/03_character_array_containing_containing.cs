var a = new char[] {  };
Solution(a, 0, 1);

char[] Solution(char[] a, int start, int len)
{
    int total = len + start; int j = 0;
    if (total > a.Length || start < 0 || len < -1) {
        Console.WriteLine("Null"); return null;
    }
    var result = new char[len];

    for (int i=start; j<len; i++) {
        result[j] = a[i];
        j++;
    }

    foreach (char c in result) {
        Console.WriteLine(c);
    }

    return result;
}
