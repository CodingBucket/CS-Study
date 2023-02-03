public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var sDict = new Dictionary<char, int>();
        var tDict = new Dictionary<char, int>();

        for (int i=0; i<s.Length; i++)
        {
            sDict[s[i]] = 1 + (sDict.ContainsKey(s[i]) ? sDict[s[i]] : 0);
            tDict[t[i]] = 1 + (tDict.ContainsKey(t[i]) ? tDict[t[i]] : 0);
        }

        foreach (char i in s)
        {
            var tCount = tDict.ContainsKey(i) ? tDict[i] : 0;
            if(tCount != sDict[i])
                return false;
        }
        return true;
    }
}
