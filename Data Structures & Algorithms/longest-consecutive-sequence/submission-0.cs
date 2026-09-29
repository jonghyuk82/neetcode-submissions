public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hash = new HashSet<int>();            
        var max = 0; 

        for(int i = 0; i < nums.Length; i++)
        {
            hash.Add(nums[i]);
        }

        for(int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            // Find start point
            if(!hash.Contains(num - 1))
            {
                int current = num;
                int count = 1;

                while(hash.Contains(current + 1))
                {
                    current += 1;
                    count++;
                }

                max = Math.Max(count, max);                
            }
        }

        return max;
    }
}
