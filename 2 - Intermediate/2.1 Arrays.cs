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
            int[] luckyNumber = { 4, 8, 16, 23, 42 };
            Console.WriteLine(luckyNumber[4]);
            luckyNumber[3] = 2;
            Console.WriteLine(luckyNumber[3]);

            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Kelly";

            Console.ReadLine(); //for pause the console
        }
    }
}
