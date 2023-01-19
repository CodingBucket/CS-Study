public class Solution {
    public int Reverse(int num) {
        long rev_num = 0;

        while (num != 0)
        {
            var reminder = num % 10;
            rev_num = rev_num * 10 + reminder;
            num = num / 10;
        }

        if (rev_num > int.MaxValue || rev_num < int.MinValue)
            rev_num = 0;
            
        return (int) rev_num;
    }
}
