public class Solution {

    public string Encode(IList<string> strs) {
        var result = "";             

        foreach(var s in strs)
        {
            var len = s.Length;
            var temp = len + "#" + s;

            result+= temp;
        }

        return result;
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        var i = 0;

        while(i < s.Length)
        {
            var j = i;                           

            while(s[j] != '#')
            {
                j++;
            }

            var len = int.Parse(s.Substring(i, j - i));
            var word = s.Substring(j + 1, len);

            result.Add(word);

            i = j + len + 1;                                                
        }

        return result;
   }
}
