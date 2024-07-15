using System;

public class Accumul
{
    public static String Accum(string s)
    {
        var sequenceOfChars =
            s.Select((character, index) => char.ToUpper(character) + new string(char.ToLower(character), index))
            .ToArray();
        return string.Join("-", sequenceOfChars);
    }

    static void Main(string[] args)
    {
        Accum("hej");
    }
}