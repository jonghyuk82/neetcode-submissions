public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var left = 0;        
        var max = 0;
        var hash = new HashSet<char>();

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
                    var l = s[left];
                    hash.Remove(l);
                    left++;
                } 

                hash.Add(c);                             
            }

            max = Math.Max(max, hash.Count);
        }

        return max;
    }
}
