using System.Runtime.Serialization;
using System.Threading.Channels;

namespace StringMerhodsCustomVariants;

class Program
{
    static void Main(string[] args)
    {
        #region LastIndexOf

        string text1 = "mehemmed";
        char character1 = 'm';
        int result1 = StringMethods.LastIndexOf(text1, character1);
        Console.WriteLine(result1);
        
        #endregion
        
        #region Split
        
        string text2 = "Mehemmed";
        char character2 = 'e';
        string[] result2 = StringMethods.Split(text2, character2);

        foreach (string s in result2)
        {
            Console.WriteLine(s);
        }
        
        #endregion
        
        #region Replace
        
        string text3 = "mehemmed";
        char character3 = 'm';
        char newCharacter = 'M';
        
        string result3 = StringMethods.Replace(text3, character3, newCharacter);

        Console.WriteLine(result3);
        
        #endregion
    }
}