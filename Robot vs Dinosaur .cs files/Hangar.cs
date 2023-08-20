using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur
{
    internal class Hangar
    {
        public Robot RobotOne; 
        public Robot RobotTwo; 
        public Robot RobotThree;
        public Robot[] Inventory;
        
        public Hangar(Robot one, Robot two, Robot three)
        {
            RobotOne = one;
            RobotTwo = two;
            RobotThree = three;
            Inventory = new Robot[] { RobotOne, RobotTwo, RobotThree };
        }

        public Robot ChooseRobot()
        {
            int roboSelection;
            Console.WriteLine($"\nChoose your Robot fighter:\n");
            int listNumber = 1;
            foreach (Robot robot in Inventory)
            {
                Console.WriteLine($"{listNumber}. {robot.Name}");
                listNumber++;
            }
            bool isInt = true;
            isInt = Int32.TryParse(Console.ReadLine(), out roboSelection);
            while (!isInt || roboSelection > Inventory.Length)
            {
                Console.WriteLine($"\nInvalid Selection.  Please enter number.");
                isInt = Int32.TryParse(Console.ReadLine(), out roboSelection);
            }
            Robot activeRobot = Inventory[roboSelection - 1];
            Console.WriteLine($"\nExcelent! You've chosen {activeRobot.Name} as your Robot");
            return activeRobot;
            //int robotSelection;
            //Console.WriteLine($"Choose your Robot fighter:\n");
            //for (int i = 0; i < Inventory.Length; i++)
            //{
            //    Console.WriteLine($"{1 + i}. {Inventory[i]}\n");
            //}
            //bool isInt = false;
            //isInt = Int32.TryParse(Console.ReadLine(), out robotSelection);
            
            //while (isInt == false || robotSelection >= Inventory.Length)
            //{
            //    Console.WriteLine("Invalid Selection.  Please enter number.");
            //    isInt = Int32.TryParse(Console.ReadLine(), out robotSelection);
            //}
            //Robot activeRobot = Inventory[robotSelection - 1];
            //return activeRobot;
        }
        public void DisplayStats(Robot activeRobot)
        {

            Console.WriteLine($"{activeRobot.Name}\nWeapon: {activeRobot.ActiveWeapon.Type}\nHealth: {activeRobot.Health}\n"); 

        }
    }
}
