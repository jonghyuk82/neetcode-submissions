public class Solution {
    public int FindMin(int[] nums) {                
        var left = 0;
        var right = nums.Length - 1;

        while(left < right)
        {            
            var mid = (right + left) / 2;
            var current = nums[mid];            

            if(current > nums[right])
            {
                left = mid + 1;
            }           
            else
            {
                right = mid;
            }
        }

        return nums[right];
    }
}
