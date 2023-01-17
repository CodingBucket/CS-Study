public class Solution {
    public bool IsPalindrome(int num) {
        long rev_num = 0;
        var n = num;

        if (n < 0)
            return false;

        while (num != 0)
        {
            var reminder = num % 10;
            rev_num = rev_num * 10 + reminder;
            num = num / 10;
        }

        return n == rev_num;
    }
}
