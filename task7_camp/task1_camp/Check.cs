using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_camp
{
    public class Check: IViewerBuy
    {
     
        public  static void OutputInfoAboutProduct(Product product)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("info about product: ");
            Console.ResetColor();
            Console.WriteLine(product);
        }
        public  static void OutputInfoAboutBuy(Buy buy)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("info about products: ");
            Console.ResetColor();
            foreach (var item in buy._allProducts)
            {
                Console.WriteLine(item);
            }
        }

        public void ViwerBuy(Buy buy)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("info about products: ");
            Console.ResetColor();
            foreach (var item in buy._allProducts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
