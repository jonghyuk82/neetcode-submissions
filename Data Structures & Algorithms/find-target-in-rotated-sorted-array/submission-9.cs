public class Solution {
    public int Search(int[] nums, int target) {        
        var left = 0;
        var right = nums.Length - 1;

        while(left <= right)
        {
            var mid = (left + right) / 2;
            var current = nums[mid];

            if(current == target)
            {
                return mid;
            }

            var leftVal = nums[left];
            var rightVal = nums[right];

            if(leftVal <= current)
            {
                if(current > target && leftVal <= target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }    
            else
            {
                if(current < target && rightVal >= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }   

        return -1;     
    }
}
