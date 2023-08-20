using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur
{
    internal class Dinosaur
    {
        //Member Variables (Has a...)
        public string Name;
        public int Health;
        public int AttackPower;   //number of health units subtracted from enemy health when used
        //Constructor
        public Dinosaur(string name)
        {
            Name = name;
            Health = 100;
            AttackPower = 10;
        }

        //Member Methods (can do...)  
        public void Attack(Robot robot)
        {
            robot.Health -= AttackPower;
            Console.WriteLine($"\n{Name} rages on {robot.Name}! {robot.Name}'s health is reduced to {robot.Health}%");
        }
        
    }
}
