﻿namespace Robot_vs_Dinosaur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dinosaur dinoOne = new Dinosaur("Primordial Bruise");
            Dinosaur dinoTwo = new Dinosaur("Velocity Raptor");
            Dinosaur dinoThree = new Dinosaur("Tri-stegotops Wrecks");
            Herd myPark = new Herd(dinoOne, dinoTwo, dinoThree);

            Robot robotOne = new Robot("N.SyN-R8r");
            Robot robotTwo = new Robot("0.BLyT.R8r");
            Robot robotThree = new Robot("E.Lym_n8r");
            Fleet myHanger = new Fleet(robotOne, robotTwo, robotThree);

            Battlefield battle1 = new Battlefield(myPark, myHanger);

            battle1.RunGame();
        }
    }
}