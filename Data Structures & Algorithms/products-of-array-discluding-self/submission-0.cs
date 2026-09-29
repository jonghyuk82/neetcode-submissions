public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var arr = new int[nums.Length];
        var prev = 1;
        var next = 1;

        for(int i = 0; i < nums.Length; i++)
        {
            if(i == 0)
            {
                arr[i] = prev;
            }
            else
            {
                arr[i] = prev * nums[i-1];                
                prev = prev * nums[i - 1];
            }            
        }

        for(int i = nums.Length - 1; i >= 0; i--)
        {
            if(i == nums.Length - 1)
            {
                arr[i] = arr[i] * next;
            }
            else
            {
                arr[i] = next * arr[i];                
            }

            next = next * nums[i];
        }

        return arr;
    }
}
