public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int startIdx = 0;
        int endIdx = numbers.Length - 1;

        while(startIdx < endIdx)
        {
            var startNum = numbers[startIdx];
            var endNum = numbers[endIdx];
            var cal = startNum + endNum;

            if(cal > target)
            {
                endIdx--;
            }
            else if(cal < target)
            {
                startIdx++;
            }                        
            else
            {
                break;
            }
        } 

        return new int[]{startIdx + 1, endIdx + 1};
    }
}
