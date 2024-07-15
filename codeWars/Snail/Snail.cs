using System.Collections.Generic;
using System.Linq;

public class SnailSolution
{
    public static int[] Snail(int[][] array)
    {
        List<int> result = new List<int>();
        int n = array.Length;

        if (n == 0 || array[0].Length != n)
        {
            return new int[0];
        }

        int top = 0;
        int bottom = n - 1;
        int left = 0;
        int right = n - 1;

        while (result.Count < n * n)
        {
            for (int i = left; i <= right; i++)
            {
                result.Add(array[top][i]);
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                result.Add(array[i][right]);
            }
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    result.Add(array[bottom][i]);
                }
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    result.Add(array[i][left]);
                }
                left++;
            }
        }

        return result.ToArray();
    }

    static void Main(string[] args)
    {
        int[][] array =
        [
            [1,2,3],
            [4,5,6],
            [7,8,9]
        ];
        Snail(array);
    }
}