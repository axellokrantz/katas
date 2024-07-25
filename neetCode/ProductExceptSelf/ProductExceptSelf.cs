public class Solution
{
    // 1,2,3,4
    // ^ 
    // i 
    //   j
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            int sum = 1;
            for (int j = 0; j < nums.Length; j++)
            {
                if(j == i)
                {
                    continue;
                }
                sum *= nums[j];
            }

            result[i] = sum;
        }
        foreach (int item in result)
        {
            Console.WriteLine(item);
        }
        return result;
    }

    static void Main()
    {
        Solution s = new();
        s.ProductExceptSelf([1, 2, 4, 6]);
    }
}
