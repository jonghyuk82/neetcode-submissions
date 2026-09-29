public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();

        foreach(var s in strs)
        {
            var count = new int[26];

            foreach(var c in s)
            {
                count[c - 'a']++;
            }

            var key = string.Join(",", count);

            if(!dic.ContainsKey(key))
            {
                dic[key] = new List<string>();
            }

            dic[key].Add(s);
        }

        return dic.Values.ToList();
    }
}
