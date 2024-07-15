namespace CodeWars
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            List<string> result = new();

            if(str.Length == 0 || str == null)
            {
                return result;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] != ' ')
                {
                    char tempChar = str[i];
                    char[] tempArr = str.ToCharArray();
                    tempChar = char.ToUpper(tempChar);
                    tempArr[i] = tempChar;
                    result.Add(new string(tempArr));
                }  
            }
            return result;
        }

        static void Main(string[] args)
        {
            Kata k = new();
            Console.WriteLine(k.wave("awd aw"));
        }
    }
}