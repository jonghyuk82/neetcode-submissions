public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if(dic.ContainsKey(num))
            {
                dic[num]++;
            }
            else
            {
                dic[num] = 1;
            }            
        }

        var sorted = dic.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();

        return sorted;

    }
}
