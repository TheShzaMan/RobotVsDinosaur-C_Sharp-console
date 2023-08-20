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
        public string AttackType1;
        public string AttackType2;
        public Random rndm;
        //Constructor
        public Dinosaur(string name)
        {
            Name = name;
            Health = 100;
            AttackType1 = "Power Smash";
            AttackType2 = "Razor Claws";
            rndm = new Random();
        }

        //Member Methods (can do...)  
        public void Attack(Robot robot)
        {
            SelectAttack();
            robot.Health -= AttackPower;
            Console.WriteLine($"{robot.Name}'s health is reduced to {robot.Health}%");
        }
        public int SelectAttack()
        {
            int rndmAttackIndex;
            string rndmAttack;
            string[] attacks = {AttackType1,  AttackType2};
            rndmAttackIndex = rndm.Next(attacks.Length);
            rndmAttack = attacks[rndmAttackIndex];
            if (rndmAttackIndex == 0)
            {
                AttackPower = 10;
                Console.WriteLine($"\n{Name} attacks with {AttackType1}!");
            }
            else
            {
                AttackPower = 30;
                Console.WriteLine($"\nWow! {Name} attacks with {AttackType2}, OUCH!");
            }
            return AttackPower;
        }
    }
}
