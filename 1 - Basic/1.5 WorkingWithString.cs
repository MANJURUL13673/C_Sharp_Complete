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
            Console.WriteLine("Haque\nLearning");    //new line
            string phrase = "Haque's Learning";
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length);  //nmumber of charaters
            Console.WriteLine(phrase.ToUpper());    //tp upper
            Console.WriteLine(phrase.Contains("Learning")); //check if substring or not
            Console.WriteLine(phrase[0]);   //1st character
            Console.WriteLine(phrase[1]);   //3rd character
            Console.WriteLine(phrase.IndexOf("Learning"));   //find which position the substring exist
            Console.WriteLine(phrase.Substring(8, 3)); //grab the part of a string

            Console.ReadLine(); //for pause the console
        }
    }
}
