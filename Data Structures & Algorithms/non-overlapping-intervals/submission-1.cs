public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));
        int x = intervals[0][1];
        int count = 0;
        for(int i=1; i<intervals.Length; i++)
        {
            if(intervals[i][0] < x)
            {
                count++;
                x = Math.Min(x, intervals[i][1]);
            }
            else
            {
                x = intervals[i][1];
            }
        }
        return count;
    }
}
