namespace StringIndexer.Models;

public class StringList
{
    public string[] Cities;
    public int Index { get; set; }
    public StringList()
    {
        Cities = new string[0];
    }

    public void AddCity(string city)
    {
        Array.Resize(ref Cities, Cities.Length + 1);
        Cities[Cities.Length - 1] = city;
    }
    
    public int this[string cityName]
    {
        get
        {
            for (int i = 0; i < Cities.Length; i++)
            {
                if (Cities[i] == cityName)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}