using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XMLParsing
{
    public class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();

            string assemblyLoc = Assembly.GetExecutingAssembly().Location;
            string executingAssemblyLoc = Directory.GetParent(assemblyLoc)?.FullName ?? string.Empty;
            string xmlFile = Path.Combine(executingAssemblyLoc, "sampleXML.xml");
            Catalog catalog = XmlDeserializer(xmlFile);
            PrintProperties(catalog.BookList);

            doc.Load(xmlFile);

            var bookList = new List<Book>();

            foreach (XmlNode node in doc.GetElementsByTagName("book"))
            {
                bookList.Add(ConvertNode<Book>(node));
            }

            PrintProperties(bookList);
            Console.ReadLine();
        }

        static Catalog? XmlDeserializer(string xmlFile)
        {
            using var stream = new StreamReader(xmlFile);
            using var xmlReader = XmlReader.Create(stream);
            var ser = new XmlSerializer(typeof(Catalog));

            return ser.Deserialize(xmlReader) as Catalog;
        }

        private static T ConvertNode<T>(XmlNode node)
        {
            T item = Activator.CreateInstance<T>();
            var props = item.GetType().GetProperties();

            foreach (XmlNode childNode in node.ChildNodes)
            {
                PropertyInfo prop = props.Single(p => p.Name.Equals(childNode.Name, StringComparison.InvariantCultureIgnoreCase));

                if (prop.PropertyType == typeof(string))
                {
                    prop.SetValue(item, childNode.InnerText);
                }
                else if (childNode.Name.ToLower().Contains("price"))
                {
                    prop.SetValue(item, Convert.ToDecimal(childNode.InnerText));
                }
                else if (childNode.Name.ToLower().Contains("date"))
                {
                    prop.SetValue(item, Convert.ToDateTime(childNode.InnerText));
                }
            }

            return item;
        }
        private static void PrintProperties<T>(IEnumerable<T> elems)
        {
            foreach (var e in elems)
            {
                PrintObject(e);
            }
        }
        private static void PrintObject<T>(T item)
        {
            Type t = item.GetType();
            Console.WriteLine(Environment.NewLine + "------BEGIN BOOK");

            foreach (PropertyInfo p in t.GetProperties())
            {
                if (p.CanRead)
                {
                    Console.WriteLine($"{p.Name}: {p.GetValue(item)}");
                }
            }

            Console.WriteLine(Environment.NewLine + "------END BOOK");
        }
    }

    [XmlRoot(ElementName = "catalog")]
    public class Catalog
    {
        [XmlElement(ElementName = "book")]
        public List<Book> BookList
        {
            get;
            set;
        }

        public Catalog()
        {
            BookList = new List<Book>();
        }
    }


    public class Book
    {
        //public string ID { get; set; }
        [XmlElement(ElementName = "author")]
        public string Author { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "genre")]
        public string Genre { get; set; }

        [XmlElement(ElementName = "price")]
        public decimal Price { get; set; }

        [XmlElement(ElementName = "publish_date")]
        public DateTime Publish_Date { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
    }
}
