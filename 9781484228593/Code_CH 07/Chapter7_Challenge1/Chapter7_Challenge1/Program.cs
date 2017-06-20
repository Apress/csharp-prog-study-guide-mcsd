using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (HTML_Reader reader = new HTML_Reader())
            {
                Console.WriteLine(reader.GetHTML("https://www.google.com"));
            }

            Console.ReadKey();
        }
    }
}
