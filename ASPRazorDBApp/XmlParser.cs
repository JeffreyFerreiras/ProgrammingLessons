using System;
using System.Linq;
using System.Xml.Linq;

namespace ASPRazorDBApp
{
    using Models;
    using System.Reflection;

    public class XmlParser
    {
        const string XML_FILE = @"D:\Development\Git\ProgrammingLessons\ASPRazorDBApp\catalog.xml";

        public static void LoadXmlFromEntity()
        {
            var xdoc = XDocument.Load(XML_FILE);
            var elems = xdoc.Root.Descendants("PLANT");

            using (var entities = new PlantsCatalogEntities())
            {
                foreach (var elem in elems)
                {
                    var p = GetPlantFrom(elem);
                    entities.Plants.Add(p);
                }

                entities.SaveChanges();
            }
        }

        private static Plant GetPlantFrom(XElement xPlant)
        {
            var plant = new Plant();      
            var childElems = xPlant.Elements().ToDictionary(x => x.Name);

            foreach (PropertyInfo prop in plant.GetType().GetProperties())
            {
                if (!prop.CanWrite) continue;

                if(childElems.ContainsKey(prop.Name))
                {
                    string value = childElems[prop.Name].Value.TrimStart('$');
                    Type type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                    prop.SetValue(plant, Convert.ChangeType(value, type));
                }
            }

            return plant;
        }
    }
}