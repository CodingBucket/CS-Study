var a = new int[] {-2,-4,-6,-8,-11};

Console.WriteLine(isOddHeavy(a));

int isOddHeavy(int[] a)
{
    int hasOdd = 0;
    for (int i=0; i<a.Length; i++) {
        if (a[i] % 2 != 0) {
            hasOdd = 1;
            for (int j =0; j<a.Length; j++) {
                if (a[j] % 2 == 0 && a[j] >= a[i]) {
                    return 0;
                }
            }
        }
    }
    if (hasOdd == 0) return 0;
    return 1;
}




