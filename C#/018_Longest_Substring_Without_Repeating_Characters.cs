public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int leftPointer = 0, rightPointer = 0, maxLength = 0;
        var charSet = new HashSet<char>();
        while (rightPointer < s.Length)
        {
            var currentChar = s[rightPointer];
            if (charSet.Contains(currentChar))
            {
                charSet.Remove(s[leftPointer]);
                leftPointer++;
            }
            else
            {
                charSet.Add(currentChar);
                var length = (rightPointer - leftPointer) + 1;
                maxLength = Math.Max(maxLength, length);
                rightPointer++;
            }
        }
        return maxLength;
    }
}
