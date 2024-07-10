public class Solution
{
    public bool ContainsDuplicate(int[] nums) {

        HashSet<int> set = new HashSet<int>();
        foreach (var num in nums)
        {
            if(!set.Add(num))
            {
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        int[] nums = {1,2,3,4,4};
        Solution s = new Solution();
        Console.WriteLine(s.ContainsDuplicate(nums));
    }
}