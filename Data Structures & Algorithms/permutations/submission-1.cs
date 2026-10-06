public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var result = new List<List<int>>();
        var combination = new List<int>();

        Search(0);
                           
        return result;

        void Search(int start)
        {
            if(nums.Length == combination.Count)
            {
                result.Add(new List<int>(combination));
                return;
            }            

            for(int i = 0; i < nums.Length; i++)
            {                            
                var current = nums[i];

                if(!combination.Contains(current))
                {
                    combination.Add(current);
                    Search(start + 1);
                    combination.RemoveAt(combination.Count - 1);
                }                
            }
        }

    }
}
