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
        var dummy = new ListNode(0);
        dummy.next = head;
        var left = dummy;
        var right = dummy;      

        // right를 n + 1칸 앞으로 이동
        for (int i = 0; i <= n; i++)
        {
            right = right.next;
        }       

        while(right != null)
        {
            left = left.next;
            right = right.next;
        }

        left.next = left.next.next;

        return dummy.next;
    }
}
