using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempratureConvertor
{
    class FahrenhiteTemprature
    {
        public double Fahrenhite { get; set; }

        // Converts Farenheite to Celcius

        public static implicit operator CelciusTemprature(FahrenhiteTemprature f)
        {
            CelciusTemprature celcius = new CelciusTemprature();
            celcius.Celcius = (f.Fahrenhite - 32) / 1.8;

            return celcius;
        }

    }

    class CelciusTemprature
    {
        public double Celcius { get; set; }

        // Converts Celcius to Farenheite

        public static implicit operator FahrenhiteTemprature(CelciusTemprature c)
        {
            FahrenhiteTemprature fahrenhite = new FahrenhiteTemprature();
            fahrenhite.Fahrenhite = c.Celcius * 1.8 + 32;

            return fahrenhite;
        }
    }
}
