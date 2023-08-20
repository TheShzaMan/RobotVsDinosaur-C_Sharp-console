using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur
{
    internal class Weapon
    {
        /////Member Variables (Has a...)/////
        public string Type;
        public int AttackPower; //number of health units to be subtracted from enemy when 

        /////Constructor/////
        public Weapon(string type, int attackPower)
        {
            Type = type;
            AttackPower = attackPower;
        }
        //public Weapon(string type)
        //{
        //    Type = type;
        //    AttackPower = 10;
        //}


        /////Member Methods (can do...)/////    
    }
}
