var a = new int[] { 1, 2, 3, 5, 5, 2, 3, 8 };
var p = new int[] { 8 };
Console.WriteLine(matches(a, p));

int matches(int[] a, int[] p)
{
    int isValid = 1;
    for (int i=0; i<p.Length; i++) {
        int start = i, end = p[i];
        bool isPositive = p[i] > 0 ? true : false;
        for (int j=start; j<end; j++) {
            if (isPositive) {
                if (a[j] < 0) {
                    isValid = 0;
                    break;
                }
            } else {
                if (a[j] > 0) {
                    isValid = 0;
                    break;
                }
            }
        }
        if (isValid == 0) break;
    }
    return isValid;
}
