using System;

namespace task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {// Молодець. кінцевий файл добре поданий.
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


        }
    }
}
