public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var dic = new Dictionary<char, int>();       
        var max = 0;
        var start = 0;

        for(int i = 0; i < s.Length; i++)
        {
            var current = s[i];

            if(dic.ContainsKey(current))
            {                
                start = Math.Max(start, dic[current] + 1);                  
            }   

            dic[current] = i;     

            max = Math.Max(max, i - start + 1);    
        }

        return max;

    }
}
