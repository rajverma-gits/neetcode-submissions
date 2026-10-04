public class Solution {
    public int LengthOfLongestSubstring(string s) {
     Dictionary<char, int> map = new Dictionary<char, int>();
     int l=0, maxLen = 0, r;
        for(r=0; r<s.Length; r++)
        {
            if(map.ContainsKey(s[r]))
            {
                maxLen = Math.Max(maxLen, r-l);
                l = Math.Max(l, map[s[r]] + 1);
            }
            map[s[r]] = r;
        }
        return Math.Max(maxLen, r-l);
    }
}
