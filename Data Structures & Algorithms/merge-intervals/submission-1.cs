public class Solution {
    public int[][] Merge(int[][] intervals) {
        List<int[]> result = new List<int[]>();
        Array.Sort(intervals, (a,b)=> a[0].CompareTo(b[0]));
        result.Add(new int[] {intervals[0][0], intervals[0][1]});
        for(int i=1; i<intervals.Length; i++)
        {
            if(intervals[i][0] <= result[result.Count-1][1])
            {
                result[result.Count-1][1] = Math.Max(result[result.Count-1][1], intervals[i][1]);
            }
            else
            {
                result.Add(new int[] {intervals[i][0], intervals[i][1]});
            }
        }
        return result.ToArray();
    }
}
