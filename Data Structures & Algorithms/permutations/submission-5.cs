public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var result = new List<List<int>>();
        var combination = new List<int>();
        var visited = new bool[nums.Length];

        Search(0);

        return result;

        void Search(int index)
        {
            if(combination.Count == nums.Length)
            {
                result.Add(new List<int>(combination));
                return;
            }


            for(int i = 0; i < nums.Length; i++)
            {
                if(!visited[i])
                {
                    visited[i] = true;
                    combination.Add(nums[i]);
                    Search(i + 1);
                    combination.RemoveAt(combination.Count - 1);
                    visited[i] = false;
                }                
            }

            return;
        }
    }
}
