public class Solution {
    public int NumIslands(char[][] grid) {
        var visited = new bool[grid.Length][];
        var count = 0;

        for(int i = 0; i < grid.Length; i++)
        {
            visited[i] = new bool[grid[i].Length];
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                var current = grid[i][j];

                if(current == '1' && !visited[i][j])
                {
                    count++;
                    Search(i, j);
                }
                
            }
        }

        return count;

        void Search(int row, int col)
        {
            var current = grid[row][col];            

            if(current == '1' && !visited[row][col])
            {
                
                visited[row][col] = true;

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
                    Search(row , col - 1);
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
