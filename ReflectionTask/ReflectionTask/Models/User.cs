namespace ReflectionTask.Models;

public class User
{
    private int Id { get; set; }
    private string Name { get; set; } 
    private string Surname{ get; set; }
    
    private static int _age;
    
    void GetFullName()
    {
        Console.WriteLine($"{Name} {Surname}");
    }

    static void ChangeAge(int age)
    {
        _age = age;
    }
}