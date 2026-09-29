public class Solution {
    public bool IsValid(string s) {
        var format = new Dictionary<char, char>();
        format.Add(')', '(');
        format.Add('}', '{');
        format.Add(']', '[');

        var stack = new Stack<char>();

        for(int i = 0; i < s.Length; i++)
        {
            var c = s[i];

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
                
                var pair = format[c];                
                var open = stack.Pop();

                if(pair != open)
                {
                    return false;
                }
            }
        }

        return stack.Count == 0 ? true : false;
    }
}
