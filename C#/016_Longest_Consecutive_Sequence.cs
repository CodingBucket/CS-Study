public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        Array.Sort(nums);
        var set = new HashSet<int>(nums);
        var firstNum = nums.First();
        var count = 0;
        var maxCount = 0;
        foreach (var i in set)
        {
            if (i == firstNum)
            {
                firstNum++;
                count++;
                maxCount = Math.Max(count, maxCount);
            }
            else
            {
                firstNum = i+1;
                count = 1;
            }
        }
        return maxCount;
    }
}
