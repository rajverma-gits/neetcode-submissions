public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        for(int i=0; i<matrix.Length; i++)
        {
            if(matrix[i][0] > target)
            {
                return false;
            }
            int lastCol = matrix[i].Length-1;
            if(matrix[i][0] <= target || matrix[i][lastCol] >= target)
            {
                int l = 0, r = lastCol;
                while(l <= r)
                {
                    int mid = (l+r)/2;
                    if(matrix[i][mid] == target)
                    {
                        return true;
                    }
                    else if(matrix[i][mid] < target)
                    {
                        l = mid+1;
                    }
                    else
                    {
                        r = mid-1;
                    }
                }
            }
        }
        return false;
    }
}
