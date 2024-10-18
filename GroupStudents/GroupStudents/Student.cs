namespace GroupStudents;

public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }

    private string _gender;
    public string Gender
    {
        get => _gender;
        set
        {
            if (value == "female" || value == "male")
            {
                _gender = value;
            }
            else
            {
                Console.WriteLine("Invalid gender");
            }
        }
    }
    private int _age;
    public int Age
    {
        get => _age;

        set
        {
            if (value > 18)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Invalid age");
            }
        }
    }
    public string PhoneNumber { get; set; }
    public int Limit { get; set; } = 24;
    
    private string _studentGroup;
    public string StudentGroup 
    {
        get => _studentGroup;
        set
        {     
            for (int i = 0; i < Group.Groups.Length; i++)
            {
                if (Group.Groups[i] == value)
                {
                    _studentGroup = value;
                    return;
                }
            }

            Console.WriteLine("Invalid group");
        }
        
    }
    
    public Student(string name, string surname, string gender, int age, string phoneNumber, string studentGroup)
    {
        Name = name;
        Surname = surname;
        Gender = gender;
        Age = age;
        PhoneNumber = phoneNumber;
        StudentGroup = studentGroup;
    }
}