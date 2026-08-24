public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        List<List<string>> result = new List<List<string>>();
        int y=0;
        for(int i=0; i<strs.Length; i++)
        {
            char[] x = strs[i].ToCharArray();
            Array.Sort(x);
            string r = new string(x);
            if(!map.ContainsKey(r))
            {
                map[r] = new List<string>();
            }
            map[r].Add(strs[i]);
        }
        result = map.Values.ToList();
        return result;
    }
}
