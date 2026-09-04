public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        Comparer<int> comp = Comparer<int>.Create((a,b) => b.CompareTo(a));
        PriorityQueue<(int, int), int> q = new PriorityQueue<(int, int), int>(comp);
        int l =0;
        int[] result = new int[nums.Length - k + 1];
        for(int r=0; r<nums.Length; r++)
        {
            q.Enqueue((nums[r], r), nums[r]);
            if(r-l+1 == k)
            {
                while(q.Peek().Item2 < l)
                {
                    q.Dequeue();
                }
                
                result[l] = q.Peek().Item1;
                l++;
            } 
        }
        return result;
    }
}