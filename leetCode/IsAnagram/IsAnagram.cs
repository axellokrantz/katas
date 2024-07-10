
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();

        char[] sCharArray = s.ToCharArray();
        char[] tCharArray = t.ToCharArray();

        for (int i = 0; i < sCharArray.Length; i++)
        {
            if (!sDict.ContainsKey(sCharArray[i]))
            {
                sDict.Add(sCharArray[i], 1);
            }
            else
            {
                sDict[sCharArray[i]]++;
            }
        }

        for (int i = 0; i < tCharArray.Length; i++)
        {
            if (!tDict.ContainsKey(tCharArray[i]))
            {
                tDict.Add(tCharArray[i], 1);
            }
            else
            {
                tDict[tCharArray[i]]++;
            }
        }

        foreach (var valuePair in sDict)
        {
            if(!tDict.ContainsKey(valuePair.Key) || tDict[valuePair.Key] != valuePair.Value)
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        string s = "anagram";
        string t = "nagaram";
        Solution sol = new Solution();
        Console.WriteLine(sol.IsAnagram(s, t));
    }
}