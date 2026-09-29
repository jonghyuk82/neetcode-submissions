public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            var curr = nums[i];

            if(dic.ContainsKey(curr))
            {
                dic[curr]++;
            }
            else
            {
                dic.Add(curr, 1);
            }
        }


        return dic.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
               
    }
}
