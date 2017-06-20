using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Chapter_11_Code_Challenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Catalog)); // Initialzing Xml Serializer with required type
            var stream = new FileStream("Data.txt", FileMode.Open, FileAccess.Read);
            catalog = (Catalog)serializer.Deserialize(stream); // Deserializing the stream bytes

            foreach (var book in catalog.Books)
            {
                Console.WriteLine("Book ID is: {0}", book.Id);
                Console.WriteLine("Author is: {0}", book.Author);
                Console.WriteLine("Title is: {0}", book.Title);
                Console.WriteLine("Genre is: {0}", book.Genre);
                Console.WriteLine("Price is: {0}", book.Price);
                Console.WriteLine("Publish Date is: {0}", book.Publish_date);
                Console.WriteLine("Description is: {0}", book.Description);
                Console.WriteLine("**********************************************");
            }
            Console.ReadLine();
        }
    }
}
