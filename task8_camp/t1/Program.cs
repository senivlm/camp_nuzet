using System;
using task6_1;
using System.Collections.Generic;

namespace t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Energo energo = new Energo("..\\..\\..\\inputEnergy.txt");
            energo.InputInfoFromFile();
            Console.WriteLine();
            energo.ShowInfo();
            Console.WriteLine();
            energo.NotUsedElectricity();
            Console.WriteLine();
            energo.TheMostElectricityUses();
            Console.WriteLine();
            energo.Pay();
            energo.InfoToFile("..\\..\\..\\output.Energy.txt");
            Console.WriteLine();

            Energo energo1 = new Energo("..\\..\\..\\inputEnergy2.txt");
            energo1.InputInfoFromFile();
            energo1.InfoToFile("..\\..\\..\\output.Energy.txt");
            Console.WriteLine("\n\ttask8_1: ");
            List<Flat> flats1 = energo + energo1;
            foreach (Flat item in flats1)
            Console.WriteLine(item);
            Console.WriteLine("=========================================================================================================================");
            List <Flat> flats2 = energo - energo1;
            foreach(Flat item in flats2)
            Console.WriteLine(item);


        }
    }
}
