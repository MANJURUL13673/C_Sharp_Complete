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
            int num1 = 6;
            num1++;
            Console.WriteLine(num1);
            num1--;
            Console.WriteLine(num1);

            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Round(3.2));

            //Operator - +, -, *, /, %

            Console.ReadLine(); //for pause the console
        }
    }
}
