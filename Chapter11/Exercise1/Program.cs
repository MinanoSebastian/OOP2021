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
            Console.WriteLine("")
            Exercise1_1(file);
            Console.WriteLine();
            Console.WriteLine("--------");

            Exercise1_2(file);
            Console.WriteLine();
            Console.WriteLine("--------");

            Exercise1_3(file);
            Console.WriteLine();
            Console.WriteLine("--------");

            Exercise1_4(file);
            Console.WriteLine();
            Console.WriteLine("--------");


        }
        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements().Select(x => new
            {
                Name = x.Element("name").Value,
                Teammembers = x.Element("teammembers").Value
            });
            foreach(var sport in sports)
            {
                Console.WriteLine("{0} {1}", sport.Name, sport.Teammembers);
            }
        }

        private static void Exercise1_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                        .Select(x => new{
                            Firstplayed = x.Element("fistplayed").Value,
                            Name = x.Element("name").Attribute("kanji").Value
                        }).OrderBy(x => int.Parse(x.Firstplayed));

            foreach(var sport in sports)
            {
                Console.WriteLine("{0} {1}", sport.Name,sport.Fileplayed);
            } 
        }
       
        private static void Exercise1_3(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                            .Select(x => new
                            {
                                Name = x.Element("name").Value,
                                Teammembers = x.Element("teammembers").Value
                            });
                            .orderByDescending(x => int.Parse(x.Teammembers))
                            .First();
            Console.WriteLine("{0}", sports.Name);
        }

        private static void Exercise1_4(string file)
        { 
            var newfile = "sports.xml"; // 出力する新しいファイル
            var element = new XElement("novelist",
                new XElement()


            //P290 リスト11.15を参考にする
            //

        }
    }
}
