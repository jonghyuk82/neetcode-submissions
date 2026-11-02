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
    public int KthSmallest(TreeNode root, int k) {
        var count = 0;
        var result = -1;

        void Search(TreeNode node)
        {
            if(node == null)
            {
                return;
            }

            Search(node.left);

            count++;
            if(count == k)
            {
                result = node.val;
                return;
            }

            Search(node.right);
        }

        Search(root);

        return result;
    }
}
