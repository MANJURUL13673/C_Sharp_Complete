using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, plurarNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plurar noun: ");
            plurarNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(plurarNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            Console.ReadLine(); //for pause the console
        }
    }
}
