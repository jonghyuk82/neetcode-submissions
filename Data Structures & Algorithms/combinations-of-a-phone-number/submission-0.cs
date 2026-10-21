public class Solution {
    public List<string> LetterCombinations(string digits) {
        var dic = new Dictionary<int, List<char>>();
        dic.Add(2, new List<char>{'a', 'b', 'c'});
        dic.Add(3, new List<char>{'d', 'e', 'f'});
        dic.Add(4, new List<char>{'g', 'h', 'i'});
        dic.Add(5, new List<char>{'j', 'k', 'l'});
        dic.Add(6, new List<char>{'m', 'n', 'o'});
        dic.Add(7, new List<char>{'p', 'q', 'r', 's'});
        dic.Add(8, new List<char>{'t', 'u', 'v'});
        dic.Add(9, new List<char>{'w', 'x', 'y', 'z'});

        var result = new List<string>();
        var temp = new List<char>();

        if(digits.Length == 0)
        {
            return result;
        }

        Helper(0);

        return result;  

        void Helper(int index)
        {
            if(index == digits.Length)
            {
                result.Add(new string(temp.ToArray()));
                return;
            }

            var num = digits[index] - '0';

            if(dic.ContainsKey(num))
            {
                for(int i = 0; i < dic[num].Count; i++)
                {
                    temp.Add(dic[num][i]);
                    Helper(index + 1);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
        }    
    }
}
