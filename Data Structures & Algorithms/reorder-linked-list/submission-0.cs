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
    public void ReorderList(ListNode head) {
        var dummy = head;             
        var node = head;
        var list = new List<ListNode>();                

        while(node != null)
        {
            list.Add(node);
            node = node.next;
        }          

        var left = 1;
        var right = list.Count - 1;      

        while(left <= right)
        {
            if(left == right)
            {
                dummy.next = list[left];
                dummy = dummy.next;
                break;
            }

            var last = list[right];
            var prev = dummy.next;

            dummy.next = last;
            dummy = dummy.next;



            dummy.next = prev;
            dummy = dummy.next;

            left++;
            right--;
        }    

        dummy.next = null;         

    }
}
