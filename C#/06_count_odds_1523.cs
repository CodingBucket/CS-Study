public class Solution {
    public int CountOdds(int low, int high) {
        var count = 0;
        for (var i = low; i <= high; i++)
        {
            if (i % 2 != 0)
                count++;
        }
        return count;
    }
}
