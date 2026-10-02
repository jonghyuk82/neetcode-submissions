public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var result = new List<List<int>>();
        var current = new List<int>();

        Search();

        void Search()
        {
            if(current.Count == nums.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            for(int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];

                if(!current.Contains(num))
                {
                    current.Add(num);
                    Search();
                    current.RemoveAt(current.Count - 1);
                }
            }
        }

        return result;
    }
}
