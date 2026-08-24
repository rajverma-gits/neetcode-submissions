public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int l=0, r=0;
        int maxi = 0;
        while(r<nums.Length)
        {
            if(nums[r] == 0)
            {
                maxi = Math.Max(maxi, r-l);
                l = r;
                l++;
            }
            r++;
        }
        maxi = Math.Max(maxi, r-l);
        return maxi;
    }
}