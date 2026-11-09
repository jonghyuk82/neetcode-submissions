public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        Array.Sort(nums);

        var result = new List<List<int>>();
        var combination = new List<int>();

        Search(0);

        return result;

        void Search(int start)
        {
            result.Add(new List<int>(combination));

            for(int i = start; i < nums.Length; i++)
            {
                if(i > start && nums[i - 1] == nums[i])
                {
                    continue;
                }
                combination.Add(nums[i]);
                Search(i + 1);
                combination.RemoveAt(combination.Count - 1);
            }

            return;
        }
    }
}
