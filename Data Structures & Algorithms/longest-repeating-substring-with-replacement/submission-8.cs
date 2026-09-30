public class Solution {
    public int CharacterReplacement(string s, int k) {
        var dic = new Dictionary<char, int>();
        var max = 0;
        var start = 0;
        var maxCount = 0;

        for(int i = 0; i < s.Length; i++)
        {
            var c = s[i];            

            if(!dic.ContainsKey(c))
            {
                dic[c] = 1;
            }
            else
            {
               dic[c] += 1;  
                           
            }   

            maxCount = Math.Max(maxCount, dic[c]);           

            var len = i - start + 1;            
            var replace = len - maxCount;   

            while(replace > k)
            {
                dic[s[start]]--;
                start++;
                len = i - start + 1;
                replace = len - maxCount;
            }

            max = Math.Max(max, len);
                                              
        }

        return max;

    }
}
