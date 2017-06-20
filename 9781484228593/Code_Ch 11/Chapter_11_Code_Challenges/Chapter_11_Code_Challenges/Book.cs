using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Chapter_11_Code_Challenges
{
    /// <summary>
    /// Xml Structure of the Class
    /// </summary>
    [XmlRoot(ElementName = "book")]
    public class Book
    {
        [XmlElement(ElementName = "author")]
        public string Author { get; set; }
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "genre")]
        public string Genre { get; set; }
        [XmlElement(ElementName = "price")]
        public string Price { get; set; }
        [XmlElement(ElementName = "publish_date")]
        public string Publish_date { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }
}
