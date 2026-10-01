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

        var result = new ListNode(0);
        var final = result;
        var queue = new PriorityQueue<int, int>();
        

        for(int i = 0; i < lists.Length; i++)
        {
            var current = lists[i];

            while(current != null)
            {
                queue.Enqueue(current.val, current.val);
                current = current.next;
            }
        }

        while(queue.Count > 0)
        {
            result.next = new ListNode(queue.Dequeue(), null);
            result = result.next;
        }

        return final.next;
        
    }
}
