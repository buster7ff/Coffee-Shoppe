using System;
using MoneyLib;


namespace consoleMoneyTest
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            Coke c;
            Sprite s;
            c = new Coke();
            s = new Sprite();
            Console.WriteLine("Hello World!");
            Console.WriteLine("A {0} costs {1}", c.name, c.Price.Value);
            Console.WriteLine("and a {0} costs {1}", s.name, s.Price.Value);
            Console.WriteLine("Your total is {0}", s.Price.Value + c.Price.Value);
            Console.ReadLine();

        }
    }
}
