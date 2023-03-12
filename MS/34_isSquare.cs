
Console.WriteLine(isSquare(0));

int isSquare(int n)
{
    int isSquare = 0;
    for (int i=0; i<=n; i++) {
        if (i*i == n) {
            isSquare = 1;
            break;
        }
    }
    return isSquare;
}

