namespace GroupStudents;

public class blanks
{
    public static void MainSwitchBlank()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the GroupStudents app!");
        Console.WriteLine("1. Add Operations ");
        Console.WriteLine("2. Lists ");
        Console.WriteLine("3. Methods ");
        Console.WriteLine("4. Exit ");
        Console.Write("Please choose an option (1-3): ");
        string choice = Console.ReadLine();
    }
}