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
            SayHi("Mike", 36);
            SayHi("John", 32);
            SayHi("Tom", 40);

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}
