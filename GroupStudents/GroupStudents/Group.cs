namespace GroupStudents;

public class Group
{
    private string _groupName;
    public string GroupName
    {
        get => _groupName;
        set
        {
            _groupName = value;
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[^1] = _groupName;
        }
    }
    public string Shift { get; set; }
    public static string[] Groups = new string[0];
    public Student[] Students = new Student[0];

    public Group(string name, string shift)
    {
        GroupName = name;
        Shift = shift;
    }
    
    public void AddStudent(string name, string surname, string gender, int age, string phoneNumber, string group )
    {
        Student student = new Student(name, surname, gender, age, phoneNumber, group);
        Array.Resize(ref Students, Students.Length + 1);
        Students[^1] = student;
    }

    public int FindStudent(string name)
    {
        for (int i = 0; i < Students.Length; i++)
        {
            if (Students[i].Name == name)
            {
                return i + 1;
            }
        }
        
        return -1;
    }

    public void AbsentStudent(string name)
    {
        for (int i = 0; i < Students.Length; i++)
        {
            if (Students[i].Name == name)
            {
                Students[i].Limit -= 1;
            }
        }
    }

 
}