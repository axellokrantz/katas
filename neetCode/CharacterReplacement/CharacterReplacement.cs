public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int maxLength = 0;
        int replacements = k;
        int start = 0;
        int end = 1;

        if(s.Length == 0) return 0;
        else if(s.Length == 1) return 1;

        while (end < s.Length)
        {
            if(s[start] == s[end])
            {
                maxLength = Math.Max(maxLength, end - start + 1);
                end++;
            }
            else if(s[start] != s[end] && replacements > 0)
            {
                maxLength = Math.Max(maxLength, end - start + 1);
                replacements--;
                end++;
            }
            else if(s[start] != s[end] && replacements <= 0)
            {
                
            }  
        }
        
        return maxLength;
    }

    static void Main()
    {
        Solution s = new();
        string str = "XYYX";
        int k = 2;
        Console.WriteLine(s.CharacterReplacement(str, k));
    }
}
