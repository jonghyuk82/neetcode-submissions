public class Solution {
    public bool IsAnagram(string s, string t) {
        var dic = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++)
        {
            if(dic.ContainsKey(s[i]))
            {
                dic[s[i]]++;
            }
            else
            {
                dic.Add(s[i], 1);
            }
        }

        for(int i = 0; i < t.Length; i++)
        {
            if(dic.ContainsKey(t[i]) && dic[t[i]] > 0)
            {
                dic[t[i]]--;
            }           
            else
            {
                return false;
            }
        }

        foreach(var item in dic)
        {
            if(item.Value > 0)
            {
                return false;
            }
        }

        return true;
    }
}
