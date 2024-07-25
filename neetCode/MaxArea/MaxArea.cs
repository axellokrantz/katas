public class Solution
{
    public int MaxArea(int[] heights)
    {
        int maxArea = 0;
        int start = 0;
        int end = heights.Length - 1;
     
        while (start <= end)
        {
            if(heights[start] >= heights[end])
            {
                maxArea = Math.Max(maxArea, heights[end] * (end - start));
                end--;
            }
            else{
                maxArea = Math.Max(maxArea, heights[start] * (end - start));
                start++;
            }
        }
        return maxArea;
    }

    static void Main()
    {
        Solution s = new();
        s.MaxArea([1,7,2,5,4,7,3,6]);
    }
}
