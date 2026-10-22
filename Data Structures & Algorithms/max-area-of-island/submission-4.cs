public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        var max = 0;
        var count = 0;    
        
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                var curr = grid[i][j];

                if(curr == 1)
                {
                    count = 0;
                    Search(i,j);
                    max = Math.Max(max, count);
                }
            }
        }

        return max;

        void Search(int row, int col)
        {
            var current = grid[row][col];

            if(current == 0)
            {
                return;
            }

            if(current == 1)
            {
                grid[row][col] = 0;
                count++;

                // max = Math.Max(count, max);                              

                if(row > 0)
                {
                    Search(row - 1, col);
                }
                if(row < grid.Length - 1)
                {
                    Search(row + 1, col);
                }
                if(col > 0)
                {
                    Search(row, col - 1);                    
                }
                if(col < grid[row].Length - 1)
                {
                    Search(row, col + 1);
                }

                  
            }            

            return;
        }
    }
}
