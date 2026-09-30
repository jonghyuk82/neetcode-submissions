public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var hash = new HashSet<char>();
        var max = 0;
        var start = 0;

        for(int i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if(!hash.Contains(c))
            {
                hash.Add(c);
            }
            else
            {                
                while(hash.Contains(c))
                {
                    hash.Remove(s[start]);
                    start++;
                }

                hash.Add(c);
            }

            max = Math.Max(max, hash.Count);            
        }       

        return Math.Max(max, hash.Count);
    }
}
