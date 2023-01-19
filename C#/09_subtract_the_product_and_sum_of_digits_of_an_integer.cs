public class Solution {
    public int SubtractProductAndSum(int n) {
        int pro = 1;
        int sum = 0;

        while (n != 0)
        {
            var reminder = n % 10;
            sum = sum + reminder;
            pro = pro * reminder;
            n = n / 10;
        }
        return pro - sum;
    }
}
