using StringIndexer.Models;

namespace StringIndexer;

class Program
{
    static void Main(string[] args)
    {
        StringList stringList = new StringList();
        
        stringList.AddCity("London");
        stringList.AddCity("New York");
        stringList.AddCity("New Jerse");

        Console.WriteLine(stringList["New York"]);
    }
}