public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        var result = new List<List<int>>();
        var combination = new List<int>();        

        Search(0, target);

        return result;

        void Search(int start, int remaining)
        {
            if(remaining == 0)
            {
                result.Add(new List<int>(combination));                
                return;
            }                     

            for(int i = start; i < candidates.Length; i++)
            {                
                var current = candidates[i];
                
                if(current > remaining)
                {
                    break;
                }

                if(i > start && candidates[i - 1] == current)
                {
                    continue;
                }

                combination.Add(current);
                Search(i + 1, remaining - current);
                combination.RemoveAt(combination.Count - 1);
            }
        }

    }
}
