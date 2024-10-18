namespace StringMerhodsCustomVariants;

public class StringMethods
{
    public static int LastIndexOf(string text, char character) 
    {
        for (int i = text.Length - 1; i >= 0; i--)
        {
            if (text[i] == character)
            {
                return i; 
            }
        }

        return -1;
    }

    public static string[] Split(string text, char character)
    {
        int arraySize = 1; 
        foreach (char c in text)
        {
            if (c == character)
            {
                arraySize++;
            }
        }

        string[] parts = new string[arraySize];
        int index = 0;
        string part = "";

    
        foreach (char c in text)
        {
            if (c == character)
            {
                parts[index] = part;
                index++;
                part = ""; 
            }
            else
            {
                part += c; 
            }
        }

        parts[index] = part;

        return parts;
    }


    public static string Replace(string text, char character, char newCharacter)
    {
        string newText = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == character)
            {
                newText += newCharacter;
            }
            else
            {
                newText += text[i];
            }
        }

        return newText;
    }
}