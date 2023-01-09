public class Solution {
    public int MajorityElement(int[] nums) {

        var num_len = nums.Count(); // 3

        var max_el = num_len / 2; // 1

        var dic = new Dictionary<int, int>();

        for (var i = 0; i < num_len; i++)
        {
            if (dic.ContainsKey(nums[i]))
                dic[nums[i]] = dic[nums[i]] + 1;
            else
                dic.Add(nums[i], 1);

            if (dic[nums[i]] > max_el)
                return nums[i];
        }
        return -1;
    }
}
