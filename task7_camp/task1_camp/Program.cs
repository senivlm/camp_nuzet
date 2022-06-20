using System;
using System.Collections.Generic;
namespace task1_camp
{
    internal class Program
    {
        static void Main(string[] args)
        {//Використовуйте анонімні змінні
            DateTime date1 = new DateTime(2015, 7, 20);
            DairyProduct dairyProduct1 = new DairyProduct("milk", 2.5, 0.9, date1);


            Product product1 = new Product("apple", 2, 3);


            Meat meat = new Meat("beef stake", 20, 1.5, CategoryOfMeat.HightSort1, SpeciesOfMeat.beef);


            Buy buy = new Buy(product1, meat);
            buy.AddProduct(dairyProduct1);

            Check.OutputInfoAboutBuy(buy);
            Check.OutputInfoAboutProduct(meat);
            buy.TotalPrice();
            buy.TotalWeight();
            buy.AllProducts();

            //Storage storage = new Storage();
            //storage.InputProducts();

            //IViewerBuy check = new Check();
            //check.ViwerBuy(buy);

            //IViewerBuy checkDecor = new CheckDecor();
            //checkDecor.ViwerBuy(buy);


            Storage storage2 = new Storage();
         
            storage2.InputFromFile();
            storage2.ShowRegistration();
            storage2.Show();
            
           



        }
    }
}
