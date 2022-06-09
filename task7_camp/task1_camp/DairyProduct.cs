using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_camp
{
    internal class DairyProduct:Product
    {
        public DateTime expirationDate { get; private set; }

        public DairyProduct():this(default,default,default,default)
        {

        }
        public DairyProduct(string name, double price, double weight, DateTime dateTime):base(name,price,weight)
        {
            if(dateTime == null)
            {
                throw new ArgumentNullException("Error!");
            }
            expirationDate = dateTime;
           
        }
        public override void ChangePrice(int percent)
        {
           if(IsExpired())
            {
                percent = percent>40? percent -30 : percent;

            }
           Price = (int)((double)Price *(percent/100));
        }

        public bool IsExpired()
        {
            return DateTime.Now > expirationDate;
        }


        public override string ToString()
        {
            return base.ToString() + string.Format($"   expirationDate:{expirationDate}");
        }

    }
}
