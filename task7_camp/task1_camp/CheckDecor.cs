using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_camp
{
    internal class CheckDecor : IViewerBuy
    {
        //public int CompareTo(object? obj)
        //{
        //   if()
        //    {

        //    }
        //}

        public void ViwerBuy(Buy buy)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("info about products: ");
            Console.ResetColor();
            foreach (var item in buy._allProducts)
            {
                Console.WriteLine("********************\n" + item+"\n********************");
            }
        }
    }
}
