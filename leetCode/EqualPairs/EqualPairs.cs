using System.ComponentModel.Design;

public class Solution
{
    public int EqualPairs(int[][] grid)
    {
        List<List<int>> rows = new();
        List<List<int>> columns = new();
        int pairCount = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            List<int> row = new();
            for (int j = 0; j < grid.Length; j++)
            {
                row.Add(grid[i][j]);
            }
            rows.Add(row);
        }

        for (int i = 0; i < grid.Length; i++)
        {
            List<int> column = new();
            for (int j = 0; j < grid.Length; j++)
            {
                column.Add(grid[j][i]);
            }
            columns.Add(column);
        }

        for (int i = 0; i < rows.Count; i++)
        {
            for (int j = 0; j < rows.Count; j++)
            { 
                if(AreListEqual(rows[i], columns[j]))
                {
                    pairCount++;
                }   
            }
        }
        return pairCount;
    }

    private bool AreListEqual(List<int> a, List<int> b)
    {
        if(a.Count != b.Count) return false;
        for (int i = 0; i < a.Count; i++)
        {
            if(a[i] != b[i])
            {
                return false;
            }
        }
        return true;
    }



    public static void Main()
    {
        Solution s = new();
        int[][] matrix =
        [[3,1,2,2],
         [1,4,4,4],
         [2,4,2,2],
         [2,5,2,2]];

        Console.WriteLine(s.EqualPairs(matrix));
    }
}