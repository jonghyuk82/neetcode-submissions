public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var hash = new HashSet<char>();
        var left = 0;
        var max = 0;

        for(int i = 0; i < s.Length; i++)
        {
            var current = s[i];

            while(hash.Contains(current))
            {
                hash.Remove(s[left]);
                left++;
            }                         

            hash.Add(current);

            max = Math.Max(max, i - left + 1);
        }

        return max;
    }
}
