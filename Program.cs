using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Library schooLibrary = new Library();
            schooLibrary.studentsList.Add("Poul");
            schooLibrary.booksList.Add(new Book("The Da Vinci Code", 608, "detective", "Dan Brown", 2003));
            schooLibrary.booksList.Add(new Book("Harry Potter and the philosopher's stone", 640, "fantasy", "Joanne K. Rowling", 1997));

            schooLibrary.studentsList.Add("John");
            schooLibrary.booksList.Add(new Book("Labyrinth", 531, "historical fiction", "Kate Mosse", 2005));
            schooLibrary.booksList.Add(new Book("Lost in the Jungle", 248, "biographcal", "Yossi Ghinsberg", 1985));

            schooLibrary.All();
            Console.ReadKey();
        }
    }
}
