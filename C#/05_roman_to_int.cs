public class Solution {
    public int RomanToInt(string s) {  //L13
        var dict = new Dictionary<char, int> {{'I', 1}, {'V', 5}, {'X',  10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}};

        s = s.Replace("IV", "IIII");
        s = s.Replace("IX", "VIIII");
        s = s.Replace("XL", "XXXX");
        s = s.Replace("XC", "LXXXX");
        s = s.Replace("CD", "CCCC");
        s = s.Replace("CM", "DCCCC");

        var r = 0;

        foreach (var i in s)
        {
            r = r + dict[i];
        }

        return r;
    }
}
