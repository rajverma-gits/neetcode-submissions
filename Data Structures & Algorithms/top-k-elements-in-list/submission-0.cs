public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map  = new Dictionary<int, int>();
        int[] result = new int[k];
        for(int i=0; i<nums.Length; i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }
            else
            {
                map[nums[i]] = 1;
            }
        }

        result = map.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
        return result;
    }
}
