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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0) return null;

        var dummy = new ListNode(0);
        var result = dummy;
        var queue = new PriorityQueue<ListNode, int>();
        

        for(int i = 0; i < lists.Length; i++)
        {
            if(lists[i] != null)
            {
                queue.Enqueue(lists[i], lists[i].val);
            }
        }

        while(queue.Count > 0)
        {
            var smallest = queue.Dequeue();

            if(smallest.next != null)
            {
                queue.Enqueue(smallest.next, smallest.next.val);
            }

            dummy.next = smallest;
            dummy = dummy.next;
        }

        return result.next;                          
    }
}
