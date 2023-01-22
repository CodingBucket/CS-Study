var num = 1234;
var rev_num = 0;

while (num != 0)
{
    var reminder = num % 10;
    rev_num = rev_num * 10 + reminder;
    num = num / 10;
}

Console.WriteLine(rev_num);
