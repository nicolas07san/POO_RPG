using System;
using POO_RPG.src.Entities;

namespace POO_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 23);
            Ninja ninja = new Ninja("Wedge", 21);
            WhiteWizard whiteWizard = new WhiteWizard("Jenica", 20);
            BlackWizard blackWizard =  new BlackWizard("Topapa", 22);

            Console.WriteLine(knight);
            Console.WriteLine(ninja);
            Console.WriteLine(whiteWizard);
            Console.WriteLine(blackWizard);

        }
    }
}
