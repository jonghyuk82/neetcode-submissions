public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        var result = new List<List<int>>();        

        for(int i = 0; i < nums.Length; i++)
        {           
            var num = nums[i];            
            var left = i + 1;
            var right = nums.Length - 1;  

            if(i != 0 && nums[i - 1] == num)
            {
                continue;
            }          

            while(left < right)
            {
                var target = -num;
                var sum = nums[left] + nums[right];              

                if(target == sum)
                {
                    result.Add(new List<int>
                    {
                        nums[i],
                        nums[left],
                        nums[right]
                    });
                    left++;
                    right--;

                    // Skip duplicate left values
                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }
                    
                    // Skip duplicate right values
                    while (left < right && nums[right] == nums[right + 1])
                    {
                        right--;
                    }
                }     
                else
                {                    
                    if(sum > target)
                    {
                        right--;
                    }
                    else
                    {                        
                        left++;
                    }
                }                   
            }
        }

        return result;
    }
}
