public class Solution {
    public int HammingWeight(uint n) {
        var count = 0;
        while (n != 0)
        {
            if(n % 2 == 1)
                count++;
            n = n/2; //n = n >> 1;
        }
        return count;
    }
}
