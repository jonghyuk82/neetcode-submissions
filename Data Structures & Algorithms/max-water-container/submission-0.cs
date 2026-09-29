public class Solution {
    public int MaxArea(int[] heights) {
        var left = 0;
        var right = heights.Length - 1;
        var max = 0;

        while(left < right)
        {
            var h = Math.Min(heights[left], heights[right]);
            var w = right - left;
            var area = h * w;
            max = Math.Max(area, max);

            if(heights[right] < heights[left])
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return max;
    }
}
