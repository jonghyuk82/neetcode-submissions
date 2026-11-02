public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var result = new List<List<int>>();
        var temp = new List<int>();
        var visited = new bool[nums.Length];

        Search();

        return result;

        void Search()
        {
            if(temp.Count == nums.Length)
            {
                result.Add(new List<int>(temp));
                return;
            }

            for(int i = 0; i < nums.Length; i++)
            {  
                if(!visited[i])
                {
                    visited[i] = true;
                    temp.Add(nums[i]);
                    Search();
                    temp.RemoveAt(temp.Count - 1);
                    visited[i] = false;
                }              
                
            }
        }
    }
}
