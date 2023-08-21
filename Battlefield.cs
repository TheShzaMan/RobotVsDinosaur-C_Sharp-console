using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur
{
    internal class Battlefield
    {
        //Member Variables (Has a...)
        public Dinosaur ActiveDino;
        public Robot ActiveRobot;
        public Weapon ActiveWeapon;
        public Fleet Hangar;
        public Herd TriassicPark;
        //Constructor
        public Battlefield(Herd triassicPark, Fleet hangar)
        {
            TriassicPark = triassicPark;
            Hangar = hangar;
        }

        //Member Methods (can do...)  
        public void DisplayWelcome()
        {
            Console.WriteLine("Ladies and Gentlemen, welcome to Robot vs Dinosaur!");
        }

        public void SelectFighters()
        {
            ActiveDino = TriassicPark.ChooseDinosaur();
            ActiveRobot = Hangar.ChooseRobot();
            ActiveWeapon = ActiveRobot.SelectWeapon(ActiveRobot);

            Console.WriteLine($"\nLadies and gentlemen, for tonight's battle, we have...\n" +
                $"Fighting for the Robots...\n");
            Hangar.DisplayStats(ActiveRobot);
            Console.WriteLine($"\n\n and for the Dinosaurs...\n");
            TriassicPark.DisplayStats(ActiveDino);
            Console.WriteLine($"\nHERE WE GO!!!   ...press enter");Console.ReadLine();

        }
        public void BattleSequence()
        {
            while (ActiveDino.Health > 0 && ActiveRobot.Health > 0)
            {
                ActiveDino.Attack(ActiveRobot);
                if(ActiveRobot.Health == 0)
                {
                    break;
                }
                //else if(ActiveDino.Health ==0)
                //{
                //    break;
                //}
                ActiveRobot.Attack(ActiveDino);
            }
        }
        public void AnnounceWinner()
        {
            if (ActiveRobot.Health == 0)
            {
                Console.WriteLine($"\nWow!! What a fight!!  The winner is...\n" +
                $"\n{ActiveDino.Name} for the Dinosaurs!!");
            }
            else
            {
                Console.WriteLine($"\nWow!! What a fight!!  The winner is...\n" +
                    $"\n{ActiveRobot.Name} for the Robots!!");
            }
        }

        public void RunGame()
        {
            DisplayWelcome();

            SelectFighters();
          
            BattleSequence();
            
            AnnounceWinner();
        }
    }
}

    


