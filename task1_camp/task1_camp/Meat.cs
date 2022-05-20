using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_camp
{

    public enum Category
    {
        HightSort1,
        Sort2,
    }

    public enum Species
    {
        chicken,
        mutton,
        veal,
        pork,
        beef
    }
    internal class Meat:Product
    {
        public Category _meatCategory { get; }

        public Species _meatSpecies { get; }

        public Meat(): this(default,default,default,default,default)
        {

        }
        public Meat(string name, double price, double weight, Category category, Species species): base(name, price , weight)
        {
            _meatCategory = category;
            _meatSpecies = species;
        }

        public override void ChangePrice(int percent)
        {
            switch(_meatCategory)
            {
                case Category.HightSort1:
                    percent += 25;
                    break;
                case Category.Sort2:
                    percent += 10;
                    break;
                default:
                    break;
            }
            Price = (int)((double)Price * (percent / 100d));
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($"   meat category: {_meatCategory}   meat species: {_meatSpecies}");
        }


    }
}
