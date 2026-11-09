public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);

        var result = new List<List<int>>();
        var combination = new List<int>();        

        Search(0);

        return result;

        void Search(int index)
        {
            result.Add(new List<int>(combination));

            for(int i = index; i< nums.Length; i++)
            {
                if(i > index && nums[i - 1] == nums[i])
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
