var a = new int[] {7,7,7,7,7,7 };

Console.WriteLine(isPacked(a));

int isPacked(int[] a)
{
    for (int i=0; i<a.Length; i++) {
        int count = 1;
        for (int j=0; j<a.Length; j++) {
            if (i!=j && a[i] == a[j]) {
                count++;
                if (count > a[i]) return 0;
            }
        }
        if (count != a[i]) return 0;
    }

    return 1;
}




