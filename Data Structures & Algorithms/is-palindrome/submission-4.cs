public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;
        var ss = s.ToLower();

        while(left < right)
        {
            var first = ss[left];

            while(left < right && !char.IsLetterOrDigit(first))
            {
                left++;
                first = ss[left];
            }

            var last = ss[right];
            
            while(left < right && !char.IsLetterOrDigit(last))
            {
                right--;
                last = ss[right];
            }           

            if(first != last)
            {
                return false;
            }     

            left++;
            right--;       
        }

        return true;
    }
}
