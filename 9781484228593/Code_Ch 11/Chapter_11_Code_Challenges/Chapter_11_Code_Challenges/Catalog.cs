using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Chapter_11_Code_Challenges
{
    /// <summary>
    /// Xml Structure of the class
    /// </summary>
    [XmlRoot(ElementName = "catalog")]
    public class Catalog
    {

        [XmlElement(ElementName = "book")]
        public List<Book> Books { get; set; }
    }
}
