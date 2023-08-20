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
        public Hangar MyHangar;
        public TriassicPark MyPark;
        
        //Constructor

        public Battlefield(TriassicPark myPark, Hangar myHangar)
        {
            MyPark = myPark;
            MyHangar = myHangar;
        }

        //Member Methods (can do...)  
        public void DisplayWelcome()
        {
            Console.WriteLine("Ladies and Gentlemen, welcome to Robot vs Dinosaur!");
        }

        public void SelectFighters()
        {
            ActiveDino = MyPark.ChooseDinosaur();
            ActiveRobot = MyHangar.ChooseRobot();
            ActiveWeapon = ActiveRobot.SelectWeapon(ActiveRobot);

            Console.WriteLine($"\nLadies and gentlemen, for tonight's battle, we have...\n" +
                $"Fighting for the Robots...\n");
            MyHangar.DisplayStats(ActiveRobot);
            Console.WriteLine($"\n\n and for the dinosaurs...\n");
            MyPark.DisplayStats(ActiveDino);
            Console.WriteLine($"\nHERE WE GO!!!   ...press enter");

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
            
            //dinoFighter attack roboFighter;
            //display roboFighter health
            //roboFighter attack dinoFighter
            //display dinoFighter health
            //loop this ^ until fighter has 0 health
            //inform of death
        }
        public void AnnounceWinner()
        {
            if (ActiveRobot.Health == 0)
            {
                Console.WriteLine($"Wow!! What a fight!!  The winner is...\n" +
                $"{ActiveDino.Name}");
            }
            else
            {
                Console.WriteLine($"Wow!! What a fight!!  The winner is...\n" +
                    $"{ActiveRobot.Name}");
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

    


