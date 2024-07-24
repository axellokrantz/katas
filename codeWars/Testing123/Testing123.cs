using System.Linq;

public class LineNumbering 
{
    public static List<string> Number(List<string> lines) 
    {
       return lines.Select((line, index) => $"{index + 1}: {line}").ToList();
    }

    static void Main(string[] args)
    {
        List<string> list = new() {"a", "b"};
        list = Number(list);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}