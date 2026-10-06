public class Solution {
    public bool Exist(char[][] board, string word) {
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[i].Length; j++)
            {                                
                if(Search(i, j, 0))
                {
                    return true;
                }                                       
            }
        }

        return false;

        bool Search(int row, int col, int index)
        {
            if(index == word.Length)
            {
                return true;
            }

            var c = board[row][col];
            bool result = false;

            if(c == word[index])
            {
                var temp = c;
                board[row][col] = '#';  
                var up = false;
                var down =false;
                var left = false;
                var right = false;          

                if(row > 0)
                {
                    if(Search(row - 1, col, index + 1))
                    {
                        up = true;
                    }
                } 
                if(row < board.Length - 1)
                {
                    if(Search(row + 1, col, index + 1))
                    {
                        down = true;
                    }
                }
                     
                if(col > 0) 
                {
                    if(Search(row, col - 1, index + 1))
                    {
                        left = true;
                    }
                }
                
                if(col < board[row].Length - 1)
                {
                    if(Search(row, col + 1, index + 1))
                    {
                        right = true;
                    }
                }

                board[row][col] = temp;

                result = up || down || left || right;

                if(index == word.Length - 1)
                {
                    return true;
                }
            }

            return result;         
        }
    }
}
