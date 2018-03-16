using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyLib;

namespace shoppeform4._0
{
    public class Product
    {
        public Money Price;
        public string Name;
        public int Volume;

        public Product(string newTitle, int newVolume, Money newAmount)
        {
            Name = newTitle;
            Volume = newVolume;
            Price = newAmount;
        }
        public override string ToString()
        {
            return Name + " : " + Price.Value;
            {
               
            }
        }
    }

    public class Pop : Product
    {
        public Pop(string popName) : base(popName, 12, new Money(new Currency("USD"), 1.75m))
        {
        
        }

    }

    public class Coke : Pop
    {
        public Coke() : base("Coke")
        {
        
        }

    }

    public class Sprite : Pop
    {
        public Sprite() : base("Sprite")
        {
        
        }
    }

    public class RootBeer : Pop
    {
        public RootBeer() : base("Root Beer")
        {
        
        }
    }

    public class Chips : Product
    {
        public Chips(String chipName, Money chipPrice) : base(chipName, 16, chipPrice)
        {
        
        }
    }

    public class Lays : Chips
    {
        public Lays() : base("Lays", new Money(new Currency("USD"), 1.99m))
        {
        
        }
    }

    public class Doritos : Chips
    {
        public Doritos() : base("Doritos", new Money(new Currency("USD"), 1.99m))
        {
        
        }
    }

    public class Kettle : Chips
    {
        public Kettle() : base("Kettle Chips", new Money(new Currency("USD"), 2.30m))
        {
        
        }
    }

    public class Sandwich : Product
    {
        public Sandwich(String sandName, Money sandPrice) : base(sandName, 6, sandPrice)
        {

        }
    }

    public class Ham : Sandwich
    {
        public Ham() : base("Ham Sandwich", new Money(new Currency("USD"), 3.99m))
        {

        }
    }

    public class Turkey : Sandwich
    {
        public Turkey() : base("Turkey Sandwich", new Money(new Currency("USD"), 3.99m))
        {
        
        }
    }

    public class Club : Sandwich
    {
        public Club() : base("Club Sandwich", new Money(new Currency("USD"), 4.50m))
        {
        
        }
    }

    public class Coffee : Product
    {
        public Coffee(String coffeeName, Money coffeePrice) : base(coffeeName, 20, coffeePrice)
        {
        
        }
    }

    public class Gormet : Coffee
    {
        public Gormet() : base("Gormet Coffee", new Money(new Currency("USD"), .99m))
        {
                   
        }
    }

    public class Cappuchino : Coffee
    {
        public Cappuchino() : base("Cappuchino", new Money(new Currency("USD"), 1.75m))
        {
             
        }
    }

    public class Espresso : Coffee
    {
        public Espresso() : base("Espresso", new Money(new Currency("USD"), 2.25m))
        {
            
        }
    }
}