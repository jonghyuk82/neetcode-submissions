public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        Array.Sort(nums);

        var result = new List<List<int>>();
        var temp = new List<int>();

        Search(0, target);

        return result;

        void Search(int index, int remaining)
        {
            if(remaining == 0)
            {
                result.Add(new List<int>(temp));
                return;
            }

            if(remaining < 0)
            {
                return;
            }

            for(int i = index; i < nums.Length; i++)
            {
                var current = nums[i];
                
                temp.Add(current);
                Search(i, remaining - current);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}
