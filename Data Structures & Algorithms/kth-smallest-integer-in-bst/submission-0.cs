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
        var stack = new Stack<TreeNode>();
        var node = root;
        if(node == null) return 0;
        var count = 0;

        stack.Push(node);
        node = node.left;

        while(stack.Count > 0)
        {
            if(node != null)
            {
                stack.Push(node);
                node = node.left;
            }
            else
            {
                var current = stack.Pop();
                count++;

                if(count == k)
                {
                    return current.val;
                }

                if(current.right != null)
                {
                    node = current.right;
                }
            }                                    
        }

        stack.Push(node);

        while(stack.Count > 0)
        {
            if(node != null)
            {
                stack.Push(node);
                node = node.left;
            }
            else
            {
                var current = stack.Pop();
                count++;

                if(count == k)
                {
                    return current.val;
                }

                if(current.right != null)
                {
                    node = current.right;
                }
            }                                    
        }

        return -1;
    }
}
