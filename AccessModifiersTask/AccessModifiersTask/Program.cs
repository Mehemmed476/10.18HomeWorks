namespace AccessModifiersTask;

class Program
{
    static void Main(string[] args)
    {
        string userUserName = "MehemmedAye";
        string userPassword = "Efsanem1!";
        string userFirstName = "Mehemmed";
        string userLastName = "Xelilzade";
        byte userAge = 20;
        DateTime userBirthday = new DateTime(2004, 07, 23);
        
        Person newPerson = new Person(userUserName, userPassword, userFirstName, userLastName, userAge, userBirthday);

        newPerson.GetInfo();






    }
}