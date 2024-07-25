public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> result = new();

        for (int i = 0; i < nums.Length - 1; i++)
        {
            HashSet<int> set = new();
            for (int j = i + 1; j < nums.Length; j++)
            {
                int target = -(nums[i] + nums[j]);
                if(set.Contains(target)){
                    result.Add(new List<int> {nums[i], nums[j], target});
                }
                else{
                    set.Add(nums[j]);
                }
            }
        }
        return result;
    }

    static void Main(){
        Solution s = new();
        s.ThreeSum([-1,0,1,2,-1,-4]);
    }
}