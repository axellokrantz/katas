public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1 == s2) return true;
        int n = s1.Length;

        for (int i = 0; i <= s2.Length - s1.Length; i++)
        {
            string window = s2.Substring(i, s1.Length);
            if(IsPermutation(s1, window))
            {
                return true;
            }
        }

        return false;
    }

    static bool IsPermutation(string s1, string window)
    {
        if(s1.Length != window.Length) return false;
        int[] count = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            count[s1[i] - 'a']++;
            count[window[i] - 'a']--;
        }

        for (int i = 0; i < count.Length; i++)
        {
            if(count[i] != 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        Solution s = new();
        s.CheckInclusion("abc", "lecabee");
    }
}
