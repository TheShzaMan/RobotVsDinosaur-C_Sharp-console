using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur
{
    internal class TriassicPark 
    {
        public Dinosaur DinoOne;
        public Dinosaur DinoTwo;
        public Dinosaur DinoThree;
        public Dinosaur[] Herd;
        public Dinosaur ActiveDino;
        public TriassicPark(Dinosaur dinoOne, Dinosaur dinoTwo, Dinosaur dinoThree)
        {
            DinoOne = dinoOne;
            DinoTwo = dinoTwo;
            DinoThree = dinoThree;
            Herd = new Dinosaur[] {DinoOne, DinoTwo, DinoThree};
            
        }

        //public void AddDinosaur(Dinosaur dinosaur)
        //{

        //}
        public Dinosaur ChooseDinosaur()
        {
            int dinoSelection;
            Console.WriteLine($"\nChoose your Dinosaur fighter:\n");
            int listNumber = 1;
            foreach (Dinosaur dinosaur in Herd)
            {
                Console.WriteLine($"{listNumber}. {dinosaur.Name}");
                listNumber++;
            }
            bool isInt = true;
            isInt = Int32.TryParse(Console.ReadLine(), out dinoSelection);
            while (!isInt || dinoSelection > Herd.Length)
            {
                Console.WriteLine($"\nInvalid Selection.  Please enter number.");
                isInt = Int32.TryParse(Console.ReadLine(), out dinoSelection);
            }
            ActiveDino = Herd[dinoSelection - 1];
            Console.WriteLine($"\nNice! You've chosen {ActiveDino.Name} as your Dinosaur");
            return ActiveDino;
        }
        public void DisplayStats(Dinosaur activeDino)
        {
            
            Console.WriteLine($"{activeDino.Name}\nHealth: {activeDino.Health}\n");

        }
    }
}
