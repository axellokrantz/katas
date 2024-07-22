public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dict = new();
        int[] result = new int[k];
        
        for (int i = 0; i < nums.Length; i++)
        {
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], 1);
            }
            else
            {
                dict[nums[i]]++;
            }
        }

        var sortedByFreqeuency = dict.OrderBy(x => x.Value).ToList();

        for (int i = 0; i < k; i++)
        {
            
        }

        return [];
    }

    static void Main()
    {
        Solution s = new();
        s.TopKFrequent([1, 2, 2, 3, 3, 3], 2);
    }
}