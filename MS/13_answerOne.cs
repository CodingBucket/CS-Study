int answerOne(int a)
{
    for (int i = 1; i < a; i++)
    {
        for (int j = i + 1; j < a; j++)
        {
            if (i * i + j * j == a)
                return 1;
        }
    }
    return 0;
}

Console.WriteLine(answerOne(50));
