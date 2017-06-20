using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempratureConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Converting Farenheite to Celcius

            FahrenhiteTemprature fahrenhite = new FahrenhiteTemprature();
            fahrenhite.Fahrenhite = 57;

            // Coverting Celcius to Farenheite

            CelciusTemprature celcius = fahrenhite;
            Console.WriteLine(celcius.Celcius);
        }
    }
}
