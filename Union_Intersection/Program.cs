using System;
using System.Linq;

namespace Union_Intersection
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

    }

    class Teacher
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }





    class Program
    {
        static void Main(string[] args)
        {




            Book[] books =

            {

            new Book() {Id=6,Title="Zitouna", Author="Slim" },
            new Book() {Id=6,Title="Filej", Author="Abdesslem" },
            new Book() {Id=3,Title="Ghilen",Author="Badra" },
            new Book() {Id=2,Title="Ghilta",Author="Nabil" },
            new Book() {Id=1,Title="Eliemaa",Author="Saber" },
            new Book() {Id=8,Title="Rome", Author="Abdesslem" }

            };

            Teacher[] teachers =

                {

                new Teacher {Firstname="Slim",Lastname="Ben Roumdhan" },
                new Teacher {Firstname="Badra", Lastname="Ghileni" }


            };

            Teacher[] teachers2 =

                {

                new Teacher {Firstname="Slim",Lastname="Ben Roumdhan" },
                new Teacher {Firstname="Badra", Lastname="Ghileni" },
                 new Teacher {Firstname="Badra", Lastname="Ayoub" }


            };
            string[] Liste1 = { "slim", "badra", "abdou" };
            string[] Liste2 = { "slim", "badra", "nabil" };


            //var concat = teachers.Union(teachers2);
            //var concat1 = teachers.Concat(teachers2);

            var concat = Liste1.Intersect(Liste2);


            //--------------------------------------------------------------------
            //var joinname = from t in teachers
            //               join b in books
            //               on t.Firstname equals b.Author
            //               select t;
            //--------------------------------------------------------------------


            //var joinname = teachers.Join(books,
            //               tname => tname.Firstname,
            //               aname => aname.Author,
            //               (tname, aname) => tname
            //               );

            //foreach (var item in concat)
            //{
            //    Console.WriteLine($"{item.Lastname}");
            //}
            //Console.WriteLine("_______________________________________");
            //foreach (var item1 in concat1)
            //{
            //    Console.WriteLine($"{item1.Lastname}");
            //}
            foreach (var item in concat)
            {
                Console.WriteLine($"{item}");
            }

           





        }

    }
}
