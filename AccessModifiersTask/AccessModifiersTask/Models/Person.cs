using System.Runtime.InteropServices.JavaScript;
using CustomValidator;

namespace AccessModifiersTask.Models;

public class Person : Validator
{
    private string _userName;

    public string UserName
    {
        get => _userName;

        set
        {
            if (UserNameValidator(value))
            {
                _userName = value;
            }

            else
            {
                Console.WriteLine("Invalid username. UserName must be longer than 2 characters.");
            }
        }
    }
    
    private string _password;

    public string Password
    {
        get => _password;

        set
        {
            if (PasswordValidator(value))
            {
                _password = value;
            }

            else
            {
                Console.WriteLine("Your password must be at least 8 characters long, and include at least one uppercase letter, one lowercase letter, one number, and one special character (@$!%*?&).");
            }
        }
    }
    
    private string _firstName;

    public string FirstName
    {
        get => _firstName;

        set
        {
            if (FirstNameValidator(value))
            {
                _firstName = value;
            }

            else
            {
                Console.WriteLine("Invalid first name. FirstName must be longer than 2 characters.");
            }
        }
    }
    
    private string _lastName;

    public string LastName
    {
        get => _lastName;
        set
        {
            if (LastNameValidator(value))
            {
                _lastName = value;
            }

            else
            {
                Console.WriteLine("Invalid last name. LastName must be longer than 2 characters.");
            }
        }
    }
    
    private byte _age;

    public byte Age
    {
        get => _age;

        set
        {
            if (AgeValidator(value))
            {
                _age = value;
            }

            else
            {
                Console.WriteLine("Invalid age. Age must be bigger than 0.");
            }
        }
    }
    
    private DateTime _birthDay;

    public DateTime Birthday
    {
        get => _birthDay;
        set
        {
            if (BirthDayValidator(_birthDay))
            {
                _birthDay = value;
            }

            else
            {
                Console.WriteLine("Invalid birthday. Birthday must be newer than 1970.");
            }
        }
    }

    public Person(string userName, string password, string firstName, string lastName, byte age, DateTime birthDay = new DateTime())
    {
        UserName = userName;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Birthday = birthDay;
    }

    public void GetInfo()
    {
        string PasswordSecret = "";
        for (int i = 0; i < Password.Length; i++)
        {
            PasswordSecret += "*";
        }

    Console.WriteLine($"Username: {UserName} \nPassword: {PasswordSecret} \nFirstName: {FirstName} \nLastName: {LastName} \nAge: {Age} \nBirthday: {Birthday}");
    }
    
}