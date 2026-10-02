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
    public TreeNode InvertTree(TreeNode root) {
        if(root == null)
        {
            return null;
        }
        var queue = new Queue<TreeNode>();    
        var node = root;
        queue.Enqueue(node);

        while(queue.Count > 0)
        {
            var current = queue.Dequeue();

            var left = current.left;
            current.left = current.right;
            current.right = left;

            if(current.left != null)
            {
                queue.Enqueue(current.left);
            }            
            if(current.right != null)
            {
                queue.Enqueue(current.right);
            }
        }        

        return root;                            
    }
}
