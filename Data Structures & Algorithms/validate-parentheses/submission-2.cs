public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> dics = new Dictionary<char, char>();
        dics.Add('(', ')');
        dics.Add('[', ']');
        dics.Add('{', '}');   

        Stack<char> stack = new Stack<char>();     

        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if(c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);                
            }
            else
            {
                if(stack.Count == 0)
                {
                    return false;
                }
                
                var open = stack.Pop();

                if(dics[open] != c)
                {
                    return false;
                }
            }            

        }

        return stack.Count == 0 ? true : false;

    }
}
