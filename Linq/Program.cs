using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()

            {
"Michael",
"Christopher",
"Jessica",
"Matthew",
"Ashley",
"Jennifer",
"Joshua",
"Amanda",
"Daniel",
"David",
"James",
"Robert",
"John",
"Joseph",
"Andrew",
"Ryan",
"Brandon",
"Jason",
"Justin",
"Sarah",
"William",
"Jonathan",
"Stephanie",
"Brian"
,"Nicole"
,"Nicholas"
,"Anthony"
,"Heather",
"Eric",
"Elizabeth",

            };


            //var r = from x in Moyennes where x >= 10 select x;



            //var r = Moyennes.Where(item => item > 10);

            var r = names.Where(x => (x.Length > 5 && x.StartsWith("A")) || x.EndsWith("n"));



            int i = 1;

            foreach (var item in r)
            {
                Console.WriteLine($"{i}------{item}  ");
                i++;

            }

            Console.WriteLine($"______________________________");
            Console.WriteLine($" Tolal {i - 1}");

            Console.Read();

        }



    }
}
