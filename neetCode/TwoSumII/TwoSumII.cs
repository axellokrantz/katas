public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
       int start = 0;
       int end = numbers.Length - 1;

       while(start < end)
       {
            if(numbers[start] + numbers[end] == target)
            {
                return [start + 1, end + 1];
            }
            else if(numbers[start] + numbers[end] > target)
            {
                end--;
            }
            else
            {
                start++;
            }
       }
       throw new Exception("No indices found for the specified target.");
    }

    static void Main()
    {
        Solution s = new();
        s.TwoSum([2,7,11,15], 5);
    }
}