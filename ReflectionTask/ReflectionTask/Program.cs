using System.Reflection;
using ReflectionTask.Models;

namespace ReflectionTask;

class Program
{
    static void Main(string[] args)
    {
        Type userType = typeof(User);
        object userInstance = Activator.CreateInstance(userType); //Instance yaratdim
        try
        {
            PropertyInfo? idProperty =
                userType.GetProperty("Id", BindingFlags.NonPublic | BindingFlags.Instance);
            PropertyInfo? nameProperty =
                userType.GetProperty("Name", BindingFlags.NonPublic | BindingFlags.Instance);
            PropertyInfo? surnameProperty =
                userType.GetProperty("Surname", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo? ageField = userType.GetField("_age", BindingFlags.NonPublic | BindingFlags.Static);
            MethodInfo? GetFullNameMethod =
                userType.GetMethod("GetFullName", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo? ChangeAgeMethod =
                userType.GetMethod("ChangeAge", BindingFlags.NonPublic | BindingFlags.Static);

            if (userInstance == null || idProperty == null || nameProperty == null || surnameProperty == null ||
                ageField == null)
            {
                throw new Exception("One or more property / method parameters are miss or null.");
            }

            idProperty.SetValue(userInstance, 1);
            nameProperty.SetValue(userInstance, "Mehemmed");
            surnameProperty.SetValue(userInstance, "Xelilzade");
            ageField.SetValue(null, 20);



            foreach (PropertyInfo p in userType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine(
                    $"{p.Name}: {p.GetValue(userInstance)}"); //Burda propertylerim nonstatic oldugu ucun userType yox userInstance ile valuelerini cagirdim 
            }

            foreach (FieldInfo f in userType.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            {
                Console.WriteLine(
                    $"{f.Name}: {f.GetValue(userType)}"); // Age fieldim static oldugu ucun burda userInstance ile yox userType ile cagirmaq kifayet edir. Lakin userInstance ile cagirsaqda problem cixarmir.
            }


            GetFullNameMethod.Invoke(userInstance, null);
            ChangeAgeMethod.Invoke(null, new object[] { 21 });
            
            foreach (FieldInfo f in userType.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            {
                Console.WriteLine(
                    $"{f.Name}: {f.GetValue(userType)}"); // Age fieldim static oldugu ucun burda userInstance ile yox userType ile cagirmaq kifayet edir. Lakin userInstance ile cagirsaqda problem cixarmir.
            }
        }


        catch (TargetInvocationException ex)
        {
            Console.WriteLine("An error occurred while calling the method: " + ex.Message);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        catch (ArgumentException ex)
        {
            Console.WriteLine("Invalid argument error: " + ex.Message);
        }

        catch (Exception ex)
        {
            Console.WriteLine("Unknown Error: " + ex.Message);
        }
    }
}