
public class Solution
{
    public int[] TwoSum(int[] nums, int target) {
          
        int[] result = new int[2];
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int compliment;

        for (int i = 0; i < nums.Length; i++)
        {
            // compliment = 7, dict[0] = {7, 0}
            // compliment = 2, dict[1] = {2, 1}
            compliment = Math.Abs(nums[i] - target);
            if(dict.ContainsKey(nums[i]))
            {
                result[0] = dict[compliment];
                result[1] = i;
                return result;
            }
            dict.Add(compliment, i);
        }
        return result;
    }

    static void Main(string[] args)
    {
        int[] nums = {2,7,11,15};
        int target = 9;
        Solution s = new Solution();
        Console.WriteLine(s.TwoSum(nums, target));
    }
}