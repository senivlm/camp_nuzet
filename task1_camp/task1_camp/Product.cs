using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_camp
{
    public class Product
    { 
        public string _name { get; }

        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (_price < 0)
                {
                    Console.WriteLine("Error!");
                    throw new ArgumentException();
                }
                _price = value;
            }
        }

        public double _weight { get; }

        
        public Product():this(null,default,default)
        {

        }
        public Product(string name, double price, double weight)
        {
            if(price <0||weight<0)
            {
                Console.WriteLine("Error!");
                throw new ArgumentException();
            }
            this._name = name;
            this._price = price;
            this._weight=weight;
        }

        public override string ToString()
        {
            return string.Format($"name:{_name},   price:{_price}$,   weight:{_weight}kg");
        }

        public virtual void ChangePrice(int percent)
        {
           _price = (int)((double)_price*(percent/100d));
        }

      

    }
}
