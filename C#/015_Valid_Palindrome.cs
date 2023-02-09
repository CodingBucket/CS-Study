public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        var r = "";

        foreach (char i in s)
        {
            if (char.IsLetterOrDigit(i))
                r = r + i;
        }

        char[] stringArray = r.ToCharArray();
        Array.Reverse(stringArray);
        string reverseString = new string(stringArray);

        return r == reverseString;
    }
}
