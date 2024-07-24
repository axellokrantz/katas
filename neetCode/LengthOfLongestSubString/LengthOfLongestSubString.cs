public class Solution
{

    public static bool areDistinct(string s, int i, int j)
    {
        string subStr = s.Substring(i, j - i + 1);
        HashSet<char> set = new();
        for (int k = 0; k < subStr.Length; k++)
        {
            if(!set.Add(subStr[k]))
            {
                return false;
            }
        }
        return true;
    }

    public int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        if (n == 0) return 0;
        else if(n == 1) return 1;

        int maxLength = 0;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                if(areDistinct(s, i, j))
                {
                    maxLength = Math.Max(maxLength, j - i + 1);
                }
            }
        }
        return maxLength;
    }
    
    static void Main()
    {
        Solution s = new();
        string str = "xyzxyz";
        s.LengthOfLongestSubstring(str);
    }
}
