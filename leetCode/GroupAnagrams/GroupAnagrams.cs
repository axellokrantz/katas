
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        IList<IList<string>> list = new List<IList<string>>();

        foreach (var str in strs)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            string sortedString = new string(arr);

            if(!dict.ContainsKey(sortedString))
            {
                dict.Add(sortedString, new List<string>{str});
            }
            else
            {
                dict[sortedString].Add(str);
            }
        }

        foreach (var group in dict.Values)
        {
            list.Add(group);
        }
        
        return list;
    }

    static void Main(string[] args)
    {
        string[] strs = {"eat","tea","tan","ate","nat","bat"};
        Solution sol = new Solution();
        sol.GroupAnagrams(strs);
    }
}