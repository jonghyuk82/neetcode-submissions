public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();
        var result = new List<List<string>>();

        for(int i = 0; i < strs.Length; i++)
        {
            var s = strs[i];
            var sorted = new string(s.OrderBy(x => x).ToArray());

            if(!dic.ContainsKey(sorted))
            {
                dic[sorted] = new List<string>();
            }

            dic[sorted].Add(s);            
        }

        foreach(var item in dic)
        {
            result.Add(item.Value);
        }

        return result;


    }
}
