/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var list = new List<ListNode>();
        var node = head;

        while(node != null)
        {
            list.Add(node);
            node = node.next;
        }

        if(list.Count <= 1)
        {
            var result = new ListNode(0);
            return result.next;
        }

        if(list.Count == n)
        {
            return head.next;
        }

        var index = list.Count - n;
        var prevIndex = index - 1;
        
        list[prevIndex].next = list[index].next;

        return head;
    }
}
