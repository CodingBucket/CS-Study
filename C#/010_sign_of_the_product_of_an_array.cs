public class Solution {
    public int ArraySign(int[] nums) {
        var sign = 1;
        foreach (var i in nums)
        {
            if (i == 0)
                return 0;
            if (i < 0)
                sign = -sign;
        }
        return sign;
    }
}
