using System.Collections.Generic;

namespace CodeWars
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            int waveIndex = 0;
            List<string> result = new();

            for (int i = 0; i < str.Length; i++)
            {
                if(str[0] != ' ')
                {

                    char waver = str[waveIndex];
                    waver = char.ToUpper(waver);
                }
            }


            return result;
        }

        static void Main(string[] args)
        {
            Kata k = new();
            Console.WriteLine(k.wave(""));
        }
    }
}