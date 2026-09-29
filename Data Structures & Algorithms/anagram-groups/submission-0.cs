public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

        for(int i = 0; i < strs.Length; i++)        
        {
            var charArray = strs[i].ToCharArray();
            Array.Sort(charArray);
            string curr = new string(charArray);

            if(dic.ContainsKey(curr))
            {
                var list = dic[curr];
                list.Add(strs[i]);
                dic[curr] = list;
            }
            else
            {
                List<string> newList = new List<string>();
                newList.Add(strs[i]);                

                dic.Add(curr, newList);                
            }
        }

        var result = new List<List<string>>();

        foreach(var item in dic)
        {

            result.Add(item.Value);
        }

        return result;
    }
}
