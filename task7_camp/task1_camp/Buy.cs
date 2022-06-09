using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_camp
{
    public class Buy
    {
        public int _productsAmount { get;  private set; }

        public double _totalPrice { get; private set; }

        public double _totalWeight { get;  set; }

        public List<Product> _allProducts;

        public Buy()
        {
            _productsAmount = 0;
            _totalPrice = 0;
            _totalWeight = 0;
            _allProducts = new List<Product>();
        }

        public Buy( params Product[] products)
        {
            _productsAmount = products.Length;
            _allProducts = new List<Product> ();
             foreach (Product product in products)
             {
                _totalPrice = _totalPrice+product.Price;
                _totalWeight = _totalWeight + product._weight;
                _allProducts.Add (product);
               
             }
           
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                Console.WriteLine("Error!");
                throw new ArgumentException();
            }

            _allProducts.Add(product);
            _totalPrice = _totalPrice+ product.Price;
            _totalWeight = _totalWeight + product._weight;
            _productsAmount = _productsAmount + 1;
        }
        public void TotalPrice()
        {
            Console.WriteLine("total price:" + this._totalPrice + "$");
        }

        public void AllProducts()
        {
            Console.WriteLine("all products: " + this._productsAmount);
        }
        public void TotalWeight()
        {
            Console.WriteLine("total weight: " + this._totalWeight + "kg");
        }
      
    }
}
