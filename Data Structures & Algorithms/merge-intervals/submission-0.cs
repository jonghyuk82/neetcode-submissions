public class Solution {
    public int[][] Merge(int[][] intervals) {
        intervals = intervals.OrderBy(x => x[0]).ToArray();
        var result = new List<int[]>();
        var start = intervals[0][0];
        var end = intervals[0][1];

        for(int i = 1; i < intervals.Length; i++)
        {
            var current = intervals[i];                        
            
            if(end >= current[0])
            {
                start = Math.Min(current[0], start);
                end = Math.Max(current[1], end);
            }
            else
            {
                result.Add(new int[]{start, end});
                start = current[0];
                end = current[1];
            }
        }

        result.Add(new int[]{start, end});

        return result.ToArray();
    }
}
