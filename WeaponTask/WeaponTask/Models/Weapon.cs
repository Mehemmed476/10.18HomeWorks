using System.ComponentModel.Design;
using System.Diagnostics;

namespace WeaponTask.Models;

public class Weapon
{
    public int OneStackBulletCapacity { get; init; }
    
    private int _oneStackBulletNumber;
    public int OneStackBulletNumber
    {
        get => _oneStackBulletNumber;
        set
        {
            if (value >= 0)
            {
                _oneStackBulletNumber = value;
            }
            else
            {
                Console.WriteLine("Your Bullet finish"); 
            }
        }
    }
    
    private string _gunMode;

    public string GunMode
    {
        get => _gunMode;

        set
        {
            if (value == "singleMode" || value == "autoMode")
            {
                _gunMode = value;
            }
            else
            {
                Console.WriteLine("System Message: You must use SingleMode or AutoMode.");
            }
        }
    }

    public Weapon(int oneStackBulletCapasity, int oneStackBulletNumber, string gunMode)
    {
        OneStackBulletCapacity = oneStackBulletCapasity;
        OneStackBulletNumber = oneStackBulletNumber;
        GunMode = gunMode;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Welcome Weapon App!!!! \nYour Gun capacity is {OneStackBulletCapacity}. \nYour gun current bullet is {OneStackBulletNumber}. \nYour current mode is {GunMode}.");
    }
    public void Shoot()
    {
        OneStackBulletNumber--;
        if (OneStackBulletNumber > 0) 
        {
            Console.WriteLine($"You shot 1 bullets. You have {OneStackBulletNumber} / {OneStackBulletCapacity} bullets."); 
        }
        else
        {
            Console.WriteLine($"You can't shot, please reload your comb.  You have {OneStackBulletNumber} / {OneStackBulletCapacity} bullets."); 
 
        }
        
    }

    public void Fire()
    {
        
        if (GunMode == "autoMode" && OneStackBulletNumber > 0)
        {
            int startBullet = OneStackBulletNumber;
            Stopwatch fireModeTimer = new Stopwatch();
            
            fireModeTimer.Start();
            
            for (int i = 0; i < startBullet; i++)
            {
                OneStackBulletNumber--;
            }
            Thread.Sleep(1500);
            
            fireModeTimer.Stop();
            
            Console.WriteLine($"You shot all {startBullet} bullets in {fireModeTimer.ElapsedMilliseconds} milliseconds. Please recharge your comb. {OneStackBulletNumber} / {OneStackBulletCapacity}"); 
        }
        else
        {
            Console.WriteLine("System Message: You must use AutoMode for using Fire method.");
        }
    }

    public void GetRemainBulletCount()
    {
        int emptyCombSize = OneStackBulletCapacity - OneStackBulletNumber;
        Console.WriteLine($"You must get {emptyCombSize} bullets for full Comb");
    }

    public void Reload()
    {
        int emptyCombSize = OneStackBulletCapacity - OneStackBulletNumber;
        for (int i = 0; i < emptyCombSize; i++)
        {
            OneStackBulletNumber++;
        }
        
        Console.WriteLine($"You reload your comb. You have {OneStackBulletNumber} / {OneStackBulletCapacity} bullets");
    }

    public void ChangeFireMode()
    {
        if (GunMode == "autoMode")
        {
            GunMode = "singleMode";
        }
        else
        {
            GunMode = "autoMode";
        }
        
        Console.WriteLine($"You change Gun Mode. Current Mode: {GunMode}");
    }
    
    
    
    
}