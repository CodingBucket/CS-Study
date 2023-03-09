Console.WriteLine(solve10());

int[] solve10()
{
    var result = new int[2];
    var factorial10 = findFactorial(10);

    for (int i=1; i<10; i++) {
        var xFactorial = findFactorial(i);
        for (int j=1; j<10; j++) {
            var yFactorial = findFactorial(j);
            if (xFactorial + yFactorial == factorial10) {
                result[0] = xFactorial;
                result[1] = yFactorial;
                break;
            }
        }
    }
    return result;
}

int findFactorial(int n)
{
    int factorial = 1;
    for (int i=n; i>0; i--) {
        factorial = factorial * i;
    }
    return factorial;
}
