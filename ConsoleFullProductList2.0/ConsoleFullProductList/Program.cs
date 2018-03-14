using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyLib;

namespace ConsoleFullProductList
{
    class Program
    {
        static void Main(string[] args)
        {
            Coke c;
            Sprite s;
            Kettle k;

           // Chips h;
            //Sandwich s;
            //Coffee f;
            c = new Coke();
            s = new Sprite();
            k = new Kettle();
            //p = new Pop();
            //h = new Chips();
            //s = new Sandwich();
            //f = new Coffee();
            Console.WriteLine("A {0} costs {1}", c.Name, c.Price.Value);
            Console.WriteLine("{0} costs {1}", k.Name, k.Price.Value);
            //Console.WriteLine("A {0} costs {1}", p.Name, p.Price.Value);
            //Console.WriteLine("And {0} cost {1}", c.Name, c.Price.Value);
            //Console.WriteLine("A {0} costs {1}", s.Name, s.Price.Value);
            //Console.WriteLine("A {0} is {1}", f.Name, f.Price.Value);
            //Console.WriteLine("Total Cost: {0}", p.Price.Value + c.Price.Value + s.Price.Value + f.Price.Value);
            Console.ReadLine();

        }
    }
}
