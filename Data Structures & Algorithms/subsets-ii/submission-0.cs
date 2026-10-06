public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
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
                var current = nums[i];

                if(i > start && nums[i - 1] == current)
                {
                    continue;
                }                 

                combination.Add(current);
                Search(i + 1);
                combination.RemoveAt(combination.Count - 1);
            }
        }        
    }
}
