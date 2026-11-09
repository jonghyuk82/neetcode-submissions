public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        Array.Sort(nums);

        var result = new List<List<int>>();
        var list = new List<int>();

        Search(0, target);

        return result;


        void Search(int index, int remaining)
        {
            if(remaining == 0)
            {
                result.Add(new List<int>(list));
                return;
            }

            var current = nums[index];

            if(current > remaining)
            {
                return;
            }            

            for(int i = index; i < nums.Length; i++)
            {
                list.Add(nums[i]);
                Search(i, remaining - nums[i]);
                list.RemoveAt(list.Count - 1);
            }

            return;
        }
        
    }
}
