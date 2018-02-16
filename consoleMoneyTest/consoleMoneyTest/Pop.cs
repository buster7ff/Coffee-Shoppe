using System;
using System.Collections.Generic;
using System.Text;
using MoneyLib;

namespace consoleMoneyTest
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
}
