var a = new int[] { 1, 11, 111, 1111 };

Console.WriteLine(isVanilla(a));

int isVanilla(int[] a)
{
    int isVanilla = 1; int digit = 0;
    for (int i=0; i<a.Length; i++) {
        if (i == 0) digit = a[i] % 10;
        int item = a[i];
        while (item > 0) {
            if (item % 10 != digit) {
                isVanilla = 0;
                break;
            }
            item = item / 10;
        }
    }
    return isVanilla;
}
