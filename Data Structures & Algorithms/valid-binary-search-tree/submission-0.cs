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
    public bool IsValidBST(TreeNode root) {
        int min = int.MinValue;
        int max = int.MaxValue;

        return DFS(root, min, max);

        bool DFS(TreeNode node, int min, int max)
        {
            if(node == null)
            {
                return true;
            }

            var current = node.val;

            if(min < current && max > current)
            {
                var left = DFS(node.left, min, current);
                var right = DFS(node.right, current, max);

                return left && right;
            }

            return false;
        }
    }
}
