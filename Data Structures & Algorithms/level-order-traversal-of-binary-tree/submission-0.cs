/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> levelOrder = new List<List<int>>();
        if(root == null)
        {
            return levelOrder;
        }
        TreeNode cur = root;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(cur);
        Queue<TreeNode> levels = new Queue<TreeNode>();
        while(q.Count > 0)
        {
            levels.Enqueue(q.Dequeue());
            if(q.Count == 0)
            {
                levelOrder.Add(levels.Select(node => node.val).ToList());
                while(levels.Count > 0)
                {
                    TreeNode top = levels.Dequeue();
                    if(top.left!=null)
                    {
                        q.Enqueue(top.left);
                    }
                    if(top.right!=null)
                    {
                        q.Enqueue(top.right);
                    }
                }
            }       
        }
        return levelOrder;
    }
}
