using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyLib;

namespace shoppeform4._0
{
    public class Chips
    {
        public Money Price;
        public string name;
        public int weight;


        public Chips(string newTitle, int newVolume, Money newAmount)
        {
            name = newTitle;
            weight = newVolume;
            Price = newAmount;
        }


        public override string ToString()
        {
            return name + " : " + Price.Value;

        }
    }
    public class Lays : Chips


        {
            public Lays(): base("Lays", 5, new Money(new Currency("USD"), 2.50m))
            {


            }
        }
    public class BBQ : Chips
    {
        public BBQ(): base("BBQ",5,new Money(new Currency("USD"),3.00m))
        {

        }
    }
    public class Sour : Chips
    {
        public Sour(): base("Sour",5, new Money(new Currency("USD"), 0.75m))
        {

        }
    }
    }

