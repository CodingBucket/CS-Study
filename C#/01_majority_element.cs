public class Solution {  
    public int MajorityElement(int[] nums) {

        var num_len = nums.Count();

        var max_el = num_len / 2;

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
