using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_camp
{
    public class Check
    {
        public void ProductInformation(Buy buy)
        {
            Console.WriteLine("info about products: ");
            foreach (var item in buy._allProducts)
            {
                Console.WriteLine(item);
            }
        }
        public void TotalPrice(Buy buy)
        {
            Console.WriteLine("total price:"+buy._totalPrice+"$");
        }

        public void AllProducts(Buy buy)
        {
            Console.WriteLine("all products: "+buy._productsAmount);
        }
        public void TotalWeight(Buy buy)
        {
            Console.WriteLine("total weight: "+buy._totalWeight+"kg");
        }

    }
}
