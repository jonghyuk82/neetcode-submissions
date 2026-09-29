public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dic = new Dictionary<char, int>();

        if(s.Length != t.Length)
        {
            return false;
        }

        for(int i = 0; i < s.Length; i++)
        {
            var curr = s[i];

            if(dic.ContainsKey(curr))
            {
                dic[curr] = dic[curr] + 1;
            }
            else
            {
                dic.Add(curr, 1);
            }
        }

        for(int j = 0 ; j < t.Length; j++)
        {
            var curr = t[j];

            if(dic.ContainsKey(curr))
            {
                if(dic[curr] == 0)
                {
                    return false;
                }
                
                dic[curr] = dic[curr] - 1;
            }
            else
            {
                return false;
            }            
        }

        return true;
    }
}
