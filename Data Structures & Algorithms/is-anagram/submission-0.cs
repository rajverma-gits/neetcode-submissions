public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        for(int i=0; i < s.Length; i++)
        {
            if(map.ContainsKey(s[i]))
            {
                map[s[i]]++;
            }
            else
            {
                map[s[i]] = 1;
            }
        }

        for(int i=0; i < t.Length; i++)
        {
            if(!map.ContainsKey(t[i]))
            {
                return false;
            }
            map[t[i]]--;
            if(map[t[i]] == 0)
            {
                map.Remove(t[i]);
            }
        }

        if(map.Count > 0)
          return false;
        else
          return true;
    }
}
