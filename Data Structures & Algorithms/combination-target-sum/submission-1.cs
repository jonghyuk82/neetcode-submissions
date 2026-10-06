public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        Array.Sort(nums);
        var result = new List<List<int>>();
        var combination = new List<int>();
        var remaining = target;

        Search(0, target);

        return result;

        void Search(int start, int remaining)
        {
            if(remaining == 0)
            {
                result.Add(new List<int>(combination));
                return;
            }

            for(int i = start; i < nums.Length; i++)
            {
                var current = nums[i];

                if(current > remaining)
                {
                    break;
                }
                
                if(current <= remaining)
                {
                    combination.Add(current);
                    Search(i, remaining - current);
                    combination.RemoveAt(combination.Count - 1);
                }                
            }
        }
    }
}
