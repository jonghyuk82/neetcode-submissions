public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var queue = new PriorityQueue<int, int>();
        var dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            var current = nums[i];

            dic[i] = current;           
        }

        foreach(var item in dic)
        {
            queue.Enqueue(item.Value, item.Value);
        }
        
        var size = queue.Count - k ;

        for(int i = 0; i < size; i++)
        {
            queue.Dequeue();
        }

        return queue.Dequeue();

    }
}
