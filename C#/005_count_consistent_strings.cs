public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        var count = 0;  //L1684
        foreach (var str in words)
        {
            count++;
            foreach (var s in str)
            {
                if (!allowed.Contains(s))
                {
                    count--;
                    break;
                }
            }
        }
        return count;
    }
}
