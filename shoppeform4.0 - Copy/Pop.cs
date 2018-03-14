using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyLib;


namespace shoppeform4._0
{
    public class Pop
    {
        public Money Price;
        public string name;
        public int Volume;


        public Pop(string newTitle, int newVolume, Money newAmount)
        {
            name = newTitle;
            Volume = newVolume;
            Price = newAmount;
        }

        public override string ToString()
        {
            return name + " : " + Price.Value;
          
        }


    }

    public class Coke : Pop


    {
        public Coke() : base("Coke", 12, new Money(new Currency("USD"), 1.50m))
        {


        }
    }

    public class Sprite : Pop

    {
        public Sprite() : base("Sprite", 12, new Money(new Currency("USD"), 1.75m))
        {

        }
    }
    public class Pepsi : Pop
    {
        public Pepsi(): base("Pepsi",12,new Money(new Currency("USD"), 1.50m))
        {

        }
    }
}
