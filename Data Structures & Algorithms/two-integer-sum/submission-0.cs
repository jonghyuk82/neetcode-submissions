public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            var num = target - nums[i];

            if(dic.ContainsKey(num))
            {
                return [dic[num], i];
            }
            else
            {
                dic.Add(nums[i], i);
            }
        }

        return [];
    }
}
