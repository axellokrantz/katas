
public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        List<HashSet<int>> rows = new List<HashSet<int>>();
        List<HashSet<int>> columns = new List<HashSet<int>>();
        
        
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                rows.Add(new HashSet<int>());
                if(board[i][j] != '.')
                {
                    if(!rows[i].Contains(board[i][j]))
                    {
                        rows[i].Add(board[i][j]);
                    }
                    else
                    {
                        return false;
                    }
                }
            } 
        }

        for (int i = 0; i < board.Length; i++)
        {
            columns.Add(new HashSet<int>());
            for (int j = 0; j < board[i].Length; j++)
            {
                if(board[j][i] != '.')
                {
                    if(!columns[i].Contains(board[j][i]))
                    {
                        columns[i].Add(board[j][i]);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        for (int rowStart = 0; rowStart < 9; rowStart += 3)
        {
            for (int colStart = 0; colStart < 9; colStart += 3)
            {
                HashSet<int> subSet = new HashSet<int>();
                for (int i = rowStart; i < rowStart + 3; i++)
                {
                    for (int j = colStart; j < colStart + 3; j++)
                    {
                        if (board[i][j] != '.')
                        {
                            if (!subSet.Contains(board[i][j]))
                            {
                                subSet.Add(board[i][j]);
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }
    
        return true;
    }

    static void Main(string[] args)
    {

    
        char[][] board = 
        {
            new char[] {'5', '3', '4', '.', '7', '2', '.', '.', '.'},
            new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
            new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
            new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
            new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
            new char[] {'.', '.', '.', '.', '.', '.', '2', '8', '.'},
            new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
            new char[] {'1', '.', '.', '.', '8', '.', '.', '7', '9'}
        };

        Solution sol = new Solution();
        Console.WriteLine(sol.IsValidSudoku(board));
    }
}