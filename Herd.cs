using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur
{
    internal class Herd 
    {
        public Dinosaur DinoOne;
        public Dinosaur DinoTwo;
        public Dinosaur DinoThree;
        public Dinosaur[] Dinosaurs;
        public Dinosaur ActiveDino;
        public Herd(Dinosaur dinoOne, Dinosaur dinoTwo, Dinosaur dinoThree)
        {
            DinoOne = dinoOne;
            DinoTwo = dinoTwo;
            DinoThree = dinoThree;
            Dinosaurs = new Dinosaur[] {DinoOne, DinoTwo, DinoThree};
            
        }

        //public void AddDinosaur(Dinosaur dinosaur)
        //{

        //}
        public Dinosaur ChooseDinosaur()
        {
            int dinoSelection;
            Console.WriteLine($"\nChoose your Dinosaur fighter:\n");
            int listNumber = 1;
            foreach (Dinosaur dinosaur in Dinosaurs)
            {
                Console.WriteLine($"{listNumber}. {dinosaur.Name}");
                listNumber++;
            }
            bool isInt = true;
            isInt = Int32.TryParse(Console.ReadLine(), out dinoSelection);
            while (!isInt || dinoSelection > Dinosaurs.Length)
            {
                Console.WriteLine($"\nInvalid Selection.  Please enter number.");
                isInt = Int32.TryParse(Console.ReadLine(), out dinoSelection);
            }
            ActiveDino = Dinosaurs[dinoSelection - 1];
            Console.WriteLine($"\nNice! You've chosen {ActiveDino.Name} as your Dinosaur");
            return ActiveDino;
        }
        public void DisplayStats(Dinosaur activeDino)
        {
            
            Console.WriteLine($"{activeDino.Name}\nAttacks: Power Smash -> 10, Razor Claws -> 30\nHealth: {activeDino.Health}\n");

        }
    }
}
