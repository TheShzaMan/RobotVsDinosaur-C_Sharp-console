﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur
{
    internal class Fleet
    {
        public Robot RobotOne; 
        public Robot RobotTwo; 
        public Robot RobotThree;
        public Robot[] Inventory;
        public Fleet(Robot one, Robot two, Robot three)
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
        }
        public void DisplayStats(Robot activeRobot)
        {
            Console.WriteLine($"{activeRobot.Name}\nWeapon: {activeRobot.ActiveWeapon.Type} -> 20\nHealth: {activeRobot.Health}\n"); 
        }
    }
}
