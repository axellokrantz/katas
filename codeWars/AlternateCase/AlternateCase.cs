namespace Extensions
{
    public static class StringExt
    {
        public static string ToAlternatingCase(this string s)
        {
            if (s == null)
            {
                return "";
            }
            return new string(s.Select(letter => letter == char.ToUpper(letter) ? letter = char.ToLower(letter) : letter = char.ToUpper(letter)).ToArray());
        }

        static void Main(string[] args)
        {
            string s = "HeJpÅdIg";
            ToAlternatingCase(s);
        }
    }
}