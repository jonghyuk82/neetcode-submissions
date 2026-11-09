public class Solution {
    public int OrangesRotting(int[][] grid) {
        var queue = new Queue<(int row, int col)>();
        var fresh = 0;        

        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                var orange = grid[i][j];

                if(orange == 1)
                {
                    fresh++;
                }
                if(orange == 2)
                {
                    queue.Enqueue((i, j));
                }
            }
        }

        var time = 0;

        while(queue.Count > 0)
        {
            var size = queue.Count;            

            for(int i = 0; i < size; i++)
            {
                var orange = queue.Dequeue();

                if(orange.row > 0)
                {
                    var up = grid[orange.row - 1][orange.col];

                    if(up == 1)
                    {
                        grid[orange.row - 1][orange.col] = 2;
                        queue.Enqueue((orange.row - 1, orange.col));
                        fresh--;
                    }
                }
                if(orange.row < grid.Length - 1)
                {
                    var down = grid[orange.row + 1][orange.col];
                    if(down == 1)
                    {
                        grid[orange.row + 1][orange.col] = 2;
                        queue.Enqueue((orange.row + 1, orange.col));
                        fresh--;
                    }
                }
                if(orange.col > 0)
                {
                    var left = grid[orange.row][orange.col - 1];

                    if(left == 1)
                    {
                        grid[orange.row][orange.col - 1] = 2;
                        queue.Enqueue((orange.row, orange.col - 1));
                        fresh--;
                    }
                }
                if(orange.col < grid[orange.row].Length - 1)
                {
                    var right = grid[orange.row][orange.col + 1];
                    if(right == 1)
                    {
                        grid[orange.row][orange.col + 1] = 2;
                        queue.Enqueue((orange.row, orange.col + 1));
                        fresh--;
                    }
                }

            }

            if(queue.Count > 0)
            {
                time++;
            }                        
        }

        return fresh == 0 ? time : -1;
    }
}
