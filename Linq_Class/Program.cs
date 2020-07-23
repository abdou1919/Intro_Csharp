using System;
using System.Linq;

namespace Linq_Class
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = {

            new Book() {Id=6,Title="Zitouna", Author="Slim" },
            new Book() {Id=6,Title="Filej", Author="Abdesslem" },
            new Book() {Id=3,Title="Ghilen",Author="Badra" },
            new Book() {Id=2,Title="Ghilta",Author="Nabil" },
            new Book() {Id=1,Title="Eliemaa",Author="Saber" },
            new Book() {Id=8,Title="Rome", Author="Abdesslem" }

            };


            //var List = from item 
            //           in books
            //           where item.Title=="zitouna"
            //           select item;


            //var List = books.Where(item=> item.Title=="Zitouna");

            //------------------------------------------------------------------------------------------------------
            //var List1 = books.OrderBy(item => item.Id).ThenBy(item=> item.Author);
            //------------------------------------------------------------------------------------------------------

            var List = books.GroupBy(item => item.Author);


            foreach (var item in List)
            {
                Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
                Console.WriteLine($"Author: {item.Key}");


                foreach (var auth_book in item)
                {


                    Console.WriteLine($"\n {auth_book.Title}");



                }
                //Console.WriteLine($"{item.Id} {item.Author} {item.Title}");
                //Console.WriteLine("-----------------------------------------------");
            }

            Console.Read();











        }
    }
}
