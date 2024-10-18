namespace GroupStudents;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        Group newGroup = null;
        while (running)
        {
            Console.Clear();
            Console.Write("Welcome to the GroupStudents app! \n1. Add Operations \n2. Lists \n3. Methods \n4. Exit \nPlease choose an option (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bool case1Running = true;

                    while (case1Running)
                    { 
                        Console.Clear();
                        Console.Write("Add Operations \n1. Add Group \n2. Add Student \n3. Exit \nPlease choose an option (1-3): "); 
                        choice = Console.ReadLine();
                        
                        switch (choice)
                        {
                            case "1":
                                string groupName;
                                string shift;
            
                                Console.Write("Enter group name: ");
                                groupName = Console.ReadLine();
                                Console.Write("Enter shift: ");
                                shift = Console.ReadLine(); 
                                newGroup = new Group(groupName, shift);
                                Console.WriteLine("Group added");
                                Thread.Sleep(2000);
                                break; 
                        
                            case "2":
                                if (newGroup == null) 
                                {
                                    Console.WriteLine("You must add a group!");
                                    continue;
                                }
                    
                                string studentName;
                                string studentSurname;
                                string studentGender;
                                int studentAge;
                                string studentPhoneNumber;
                                string studentGroupName;
                    
                                Console.Write("Enter student name: ");
                                studentName = Console.ReadLine();
                                Console.Write("Enter student surname: ");
                                studentSurname = Console.ReadLine();
                                Console.Write("Enter student gender: ");
                                studentGender = Console.ReadLine();
                                Console.Write("Enter student age: ");
                                studentAge = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter student phone number: ");
                                studentPhoneNumber = Console.ReadLine();
                                Console.Write("Enter student group name: ");
                                studentGroupName = Console.ReadLine();
                    
                                newGroup.AddStudent(studentName,studentSurname ,studentGender ,studentAge, studentPhoneNumber, studentGroupName);
                                Console.WriteLine("Student added");
                                Thread.Sleep(2000);
                                break;
                        
                            case "3":
                                case1Running = false;
                                Console.WriteLine("You are going main page...");
                                Thread.Sleep(2000);
                                break;
                            default:
                                Console.WriteLine("You must select a valid option!");
                                Thread.Sleep(2000);
                                break;
                        }  
                    }
                    
                    break;
                
                case "2":
                    bool case2Running = true;

                    while (case2Running)
                    {
                        Console.Clear();
                        Console.Write("Lists \n1. Groups \n2. Students \n3.Exit \nPlease choose an option (1-3): ");  
                        choice = Console.ReadLine();
                        
                        switch (choice)
                        {
                            case "1":
                                for (int j = 0; j < Group.Groups.Length; j++)
                                {
                                    Console.WriteLine(Group.Groups[j]);
                                }
                                Thread.Sleep(5000);
                                break; 
                            
                            case "2":
                                for (int i = 0; i < newGroup.Students.Length; i++)
                                {
                                    Console.WriteLine("No       Name       Surname       Gender       Age       Phone Number       GroupName       Limit");
                                    Console.WriteLine((i + 1) + "        " +newGroup.Students[i].Name + "        " + newGroup.Students[i].Surname + "        " + newGroup.Students[i].Gender + "        " + newGroup.Students[i].Age + "        " + newGroup.Students[i].PhoneNumber + "        " + newGroup.Students[i].StudentGroup  + "        " + newGroup.Students[i].Limit);
                                }
                                Thread.Sleep(5000); 
                                break; 
                            
                            case "3":
                                case2Running = false;
                                Console.WriteLine("You are going main page...");
                                Thread.Sleep(2000); 
                                break;
                            
                            default:
                                Console.WriteLine("You must select a valid option!");
                                Thread.Sleep(2000); 
                                break;
                        }
                    }

                    break;
                
                case "3":
                    
                    bool case3Running = true;

                    while (case3Running)
                    {
                        Console.Clear();
                        Console.Write("Methods \n1. Find Student \n2. Absent Student \n3. Exit \nPlease choose an option (1-3): ");  
                        choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                string searchName;
                                Console.Write("Enter search name: ");
                                searchName = Console.ReadLine();
                                int result = newGroup.FindStudent(searchName);

                                if (result == -1)
                                {
                                    Console.WriteLine("Student not found");
                                }
                                else
                                {
                                    Console.WriteLine($"Student found in {result} no. You can check it Lists -> Student List");
                                }

                                break;
                            case "2":
                                string AbsentName;
                                Console.Write("Enter absent name: ");
                                AbsentName = Console.ReadLine();
                                newGroup.AbsentStudent(AbsentName);
                                Console.WriteLine($"Student {AbsentName} absent");
                                Thread.Sleep(2000);
                                break;
                            
                            case "3":
                                case3Running = false;
                                Console.WriteLine("You are going main page...");
                                Thread.Sleep(2000); 
                                break;
                            
                            default:
                                Console.WriteLine("You must select a valid option!");
                                Thread.Sleep(2000); 
                                break;
                        }
                    }
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Thank you for using the GroupStudents app!");
                    Thread.Sleep(2000); 
                    break;
                
                default:
                    Console.WriteLine("You must select a valid option!");
                    Thread.Sleep(2000); 
                    break;
            }
        }
    }
}
