using System;
using System.Linq;
namespace Jointure_Last_first
{
    class Voiture
    {
        public int Id { get; set; }
        public string Marque { get; set; }


    }

    class Proprietair
    {
        public int id { get; set; }
        public string Prenom { get; set; }

        public int IdVoiture { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Voiture[] Voitures = {

                new Voiture {Id=1,Marque="Fiat" },
                new Voiture {Id=2,Marque="Ferrari"},
                new Voiture {Id=3,Marque="Ford" }
            };


            Proprietair[] proprietairs = {

            new Proprietair {id=1,Prenom="Slim",IdVoiture=1 },
            new Proprietair {id=2,Prenom="Abdesslem",IdVoiture=3 },
            new Proprietair {id=2,Prenom="Badra",IdVoiture=3 }
            };


            //var join = Voitures.Join(proprietairs,
            //                          V => V.Id,
            //                          P => P.IdVoiture,
            //                          (V, P) => P

            //                            );

            var join = from v in Voitures
                       join p in proprietairs
                       on v.Id equals p.IdVoiture
                       select v;
                       




            var f = join.FirstOrDefault();
            var l = join.LastOrDefault();
            Console.WriteLine($"{ f.Marque} {l.Marque} ");
            //foreach (var item in join)
            //{
            //    Console.WriteLine($"{item.Prenom}");

            //}

            
        }
    }
}
