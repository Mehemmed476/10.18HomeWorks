using System.Text.RegularExpressions;

namespace CustomValidator;

public class Validator
{
    public bool UserNameValidator(string userName)
    {
        if (userName.Length >= 2)
        {
            return true;
        }
        
        return false;
    }
    
    public bool FirstNameValidator(string firstName)
    {
        if (firstName.Length >= 2)
        {
            return true;
        }
        
        return false;
    }
    
    public bool LastNameValidator(string lastName)
    {
        if (lastName.Length >= 2)
        {
            return true;
        }
        
        return false;
    }

    public bool PasswordValidator(string password)
    {
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
        Regex regex = new Regex(pattern);

        if (regex.IsMatch(password))
        {
            return true;
        }
        
        return false;
    }

    public bool AgeValidator(byte age)
    {
        if (age > 0)
        {
            return true;
        }
        
        return false;
    }

    public bool BirthDayValidator(DateTime birthDay)
    {
        DateTime minDate = new DateTime(1970, 01, 01);
            
        return birthDay.Year >= minDate.Year;
    }
    
}