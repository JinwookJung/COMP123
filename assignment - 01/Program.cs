using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment___01
{
    class Program
    {
        //2 /IMPLEMENT THE HERO CLASS
        static void Main(string[] args)
        {
            string name;
            
            Console.Write("Enter your hero name:");
            name = Console.ReadLine();

            Hero myHero = new Hero(name);
            myHero.show();
            myHero.fight();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
