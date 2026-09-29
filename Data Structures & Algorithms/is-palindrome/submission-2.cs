public class Solution {
    public bool IsPalindrome(string s) {     
        int startIndex = 0;
    int endIndex = s.Length - 1;        

    while (startIndex < endIndex)
    {
        // 알파벳/숫자가 아니면 건너뛰기 (break 대신 continue 사용!)
        if (!char.IsLetterOrDigit(s[startIndex]))
        {
            startIndex++;
            continue;
        }
        if (!char.IsLetterOrDigit(s[endIndex]))
        {
            endIndex--;                
            continue;
        }

        // 소문자로 변환 후 비교
        if (char.ToLower(s[startIndex]) != char.ToLower(s[endIndex]))
        {
            return false;
        }

        startIndex++;
        endIndex--;
    }

    return true;

        return true;

    }
}
