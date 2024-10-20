using WeaponTask.Models;

namespace WeaponTask;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        int userCombCapasity;
        int userCurrentCombBullet;
        string userGunMode;
        
        Console.Write("Your comb capasity: ");
        userCombCapasity = Convert.ToInt32(Console.ReadLine());
        Console.Write("Your current comb bullet: ");
        userCurrentCombBullet = Convert.ToInt32(Console.ReadLine());
        Console.Write("Current Gun Mode(singleMode / autoMode): ");
        userGunMode = Console.ReadLine();
        
        Weapon weaponObj = new Weapon(userCombCapasity, userCurrentCombBullet, userGunMode);
        
        while (running)
        {
            
            
            Console.Clear();
            Console.WriteLine("""
              0 - İnformasiya almaq üçün
              1 - Shoot metodu üçün
              2 - Fire metodu üçün
              3 - GetRemainBulletCount metodu üçün
              4 - Reload metodu üçün
              5 - ChangeFireMode metodu üçün
              6 - Proqramı dayandırmaq üçün

              Zehmet olmasa seçim edin: 
              """); 
            string choise = Console.ReadLine();

            switch (choise)
            {
                case "0":
                    weaponObj.GetInfo();
                    Thread.Sleep(2000);
                    break;
                
                case "1":
                    weaponObj.Shoot();
                    Thread.Sleep(2000);
                    break;
                
                case "2":
                    weaponObj.Fire();
                    Thread.Sleep(2000);
                    break;
                
                case "3":
                    weaponObj.GetRemainBulletCount();
                    Thread.Sleep(2000);
                    break;
                
                case "4":
                    weaponObj.Reload();
                    Thread.Sleep(2000);
                    break;
                
                case "5":
                    weaponObj.ChangeFireMode();
                    Thread.Sleep(2000);
                    break;
                
                case "6":
                    running = false;
                    Console.WriteLine("Thanks for playing!");
                    Thread.Sleep(2000);
                    break;
            }
        }
        
    }
        
    
    
}