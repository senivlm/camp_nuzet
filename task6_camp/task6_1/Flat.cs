using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_1
{
    internal class Flat
    {
        private int _number;

        public int Number
        {
            get { return _number; }
            
            set 
            {
                if(value> 0)
                {
                    _number = value;
                }
            }
        }

        private string _nameOwner;

        public string NameOwner
        {
            get { return _nameOwner; }
            set
            {
                if(value!=null)
                {
                    _nameOwner = value;
                }
                else
                {
                    _nameOwner = default(string);
                }
            }
        }

        private double _startingElectricityBill;

        public double StartingElectricityBill
        {
            get { return _startingElectricityBill; }
            set
            {
                if (value>=0)
                {
                    _startingElectricityBill = value;
                }
            }
        }

        private double _endingElectricityBill;

        public double EndingElectricityBill
        {
            get { return _endingElectricityBill; }
            set
            {
                if(value>= _startingElectricityBill)
                {
                    _endingElectricityBill = value;
                }
            }
        }
        public double UsedEnergy
        {
            get
            {
                return _endingElectricityBill - _startingElectricityBill;
            }
        }

        public DateTime _date { get; set; }

        public Flat():this(default,default,default,default,default)
        {

        }
        public Flat (int number, string name, double startEnergy , double endEnergy , DateTime date )
        {
            Number = number;
            NameOwner = name;
            StartingElectricityBill = startEnergy;
            EndingElectricityBill = endEnergy;
            _date = date;
        }

        public override string ToString()
        {
            return $"Flat Number : {_number},\t Flat Owner: {_nameOwner},\t The initial and final indicator of the electric meter: {_startingElectricityBill} || {_endingElectricityBill}, \t Date: {_date.Day} {Enum.GetName(typeof(Months), _date.Month)}";
        }
    }
}
