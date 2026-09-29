public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int, int>();

        // 1. Count frequency
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

        // index = frequency
        var bucket = new List<int>[nums.Length + 1];

        // 2. Put numbers into buckets
        foreach(var item in dic)
        {
            var count = item.Value;

            if (bucket[count] == null)
            {
                bucket[count] = new List<int>();
            }

            bucket[count].Add(item.Key);
        }

        var result = new List<int>();

        // 3. Start from the highest frequency
        for (int i = bucket.Length - 1; i >= 0; i--)
        {
            if (bucket[i] == null)
            {
                continue;
            }

            var num = bucket[i];

            for (int j = 0; j < bucket[i].Count; j++)
            {
                result.Add(bucket[i][j]);

                if (result.Count == k)
                {
                    return result.ToArray();
                }
            }
        }

        return result.ToArray();
        

    }
}
