using System;
using System.Collections.Generic;
namespace task1_camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2015, 7, 20);
            DairyProduct dairyProduct1 = new DairyProduct("milk", 2.5, 0.9, date1);


            Product product1 = new Product("apple", 2, 3);
            

            Meat meat = new Meat("beef stake", 20, 1.5, Category.HightSort1, Species.beef);
            

            Buy buy = new Buy(product1,meat);
            buy.AddProduct(dairyProduct1);

            Check check = new Check();


            
            check.AllProducts(buy);
            check.ProductInformation(buy);

           
            check.TotalPrice(buy);
            check.TotalWeight(buy);














        }
    }
}
