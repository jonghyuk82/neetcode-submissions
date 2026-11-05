public class Solution {
    public long DividePlayers(int[] skill) {
        Array.Sort(skill);
        var left = 0;
        var right = skill.Length - 1;
        var sum = skill[left] + skill[right];
        long result = 0;        

        while(left < right)
        {
            var a = skill[left];
            var b = skill[right];
            var temp = a + b;

            if(temp == sum)
            {
                var times = a * b;
                result += times;
                left++;
                right--;
            }
            else
            {
                result = -1;
                break;
            }
        }
        
        return result;

    }
}
