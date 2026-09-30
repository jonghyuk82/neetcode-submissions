public class Solution {
    public int Search(int[] nums, int target) {
        var left = 0;
        var right = nums.Length - 1;

        while(left <= right)
        {
            var mid = (right + left) / 2;
            var current = nums[mid];
            var leftValue = nums[left];
            var rightValue = nums[right];

            if(current == target)
            {
                return mid;
            }

            if(leftValue <= current)
            {
                // left sorted
                if(leftValue <= target && target < current)    
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
                // rigth sorted
                if(rightValue >= target && target > current)
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
