using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class MainApp
    {
        static void FactoryMethodPattern()
        {
            Document[] docs = new Document[2];

            docs[0] = new Resume();
            docs[1] = new Report();

            foreach(var doc in docs)
            {
                doc.CreatePages();
                //print out document name
                Console.WriteLine("\n" + doc.GetType().Name + "--");

                //print out all pages of each doc
                foreach(var page in doc.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }
    }
}
