public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int curr = nums[i];

            if(dic.ContainsKey(curr))
            {
                return true;
            }
            else
            {
                dic.Add(curr, 1);
            }
        }

        return false;
    }
}
