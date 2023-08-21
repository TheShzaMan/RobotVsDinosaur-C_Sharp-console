using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur
{
    internal class Robot
    {
        //Member Variables (Has a...)
        public string Name;
        public int Health;
        public Weapon ActiveWeapon;
        //Constructor
        public Robot(string name)
        {
            Name = name;
            Health = 100;
        }

        //Member Methods (can do...)  
        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.Health -= ActiveWeapon.AttackPower;
            Console.WriteLine($"\n{Name} activates {ActiveWeapon.Type} and attacks {dinosaur.Name}! {dinosaur.Name}'s health drops by {ActiveWeapon.AttackPower} and is now down to {dinosaur.Health}%");
        }
        public Weapon SelectWeapon(Robot robot)
        {
            Weapon weapon1 = new Weapon("Laser Stare", 20);
            Weapon weapon2 = new Weapon("Plasma Blade", 20);
            Weapon weapon3 = new Weapon("Sonic Pulse Grenades", 20);
            Weapon[] weapons = { weapon1, weapon2, weapon3 };
            
            int weaponSelection;
            Console.WriteLine($"\nSelect your robot's weapon:\n");
            int listNumber = 1;
            foreach( Weapon weapon in weapons ) 
            {
                    Console.WriteLine($"{listNumber}. {weapon.Type}");
                    listNumber++;
            }

            bool isInt = true;
            isInt = Int32.TryParse(Console.ReadLine(), out weaponSelection);
            while (!isInt || weaponSelection > weapons.Length)
            {
                Console.WriteLine($"\nInvalid Selection.  Please enter number.");
                isInt = Int32.TryParse(Console.ReadLine(), out weaponSelection);
            }
            Weapon activeWeapon = weapons[weaponSelection - 1];
            Console.WriteLine($"\nYou have equiped {robot.Name} with {activeWeapon.Type}\n" +
                $"press enter...");Console.ReadLine();
            ActiveWeapon = activeWeapon;
            return activeWeapon;
            
            
        }
    }
}
