using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine("--------");

            Exercise1_2(file);
            Console.WriteLine("--------");

            Exercise1_3(file);
            Console.WriteLine("--------");


        }
        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements();
            foreach(var xfile in xelements)
            {
                XElement xname = xfile.Element("name");
                Console.WriteLine(xname.Value);
            }
        }

        private static void Exercise1_2(string file)
        {
            var xdoc = XDocument.Load(file);

        }
       
        private static void Exercise1_3(string file)
        {
            var xdoc = XDocument.Load(file);

        }
    }
}
