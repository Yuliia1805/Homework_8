using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8._1
{
    class Program
    {
        struct Book
        {
            public string title;
            public string author;
            public int pagecount;
            public int ID;
        }
        
        static void Main(string[] args)
        {

            const int size = 4;
            Book[] books = new Book[size];
            

            books[0].title = "Delivering Happiness";
            books[0].author = "Tony Shey";
            books[0].pagecount = 304;
            books[0].ID = 97845;

            books[1].title = "It`s not about the coffee";
            books[1].author = "Gorvard Behar";
            books[1].pagecount = 190;
            books[1].ID = 74568;

            books[2].title = "My life";
            books[2].author = "Henry Ford";
            books[2].pagecount = 352;
            books[2].ID = 97851;

            books[3].title = "Elon Musk";
            books[3].author = "Ashley Vanse";
            books[3].pagecount = 406;
            books[3].ID = 86593;


            foreach (Book book in books)
            {
                Console.WriteLine("Title: " + book.title + "\nAuthor: " + book.author + "\nPagecount: " + book.pagecount + "\nID: " + book.ID + "\n");
            }

            int maxPages = 0;
            maxPages = books[0].pagecount;
            int count = 0;

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].pagecount > maxPages)
                {
                    maxPages = books[i].pagecount;
                    count = i;
                }
            }
            Console.WriteLine("Book with max count of pages: " + maxPages + " , " + books[count].title);

            int minID = 0;
            int maxID = 0;

            minID = books[0].ID;
            maxID = books[0].ID;

            for (int i = 0; i < books.Length; i++)
            {
                if(books[i].ID < minID)
                {
                    minID = books[i].ID;
                    count = i;
                }
                if (books[i].ID > maxID)
                {
                    maxID = books[i].ID;
                    count = i;
                }
            }
            Console.WriteLine("Min ID = {0}, Max ID = {1}", minID, maxID);

            


            for (int i = 0; i < books.Length; i++)
            {
                for (int j = 0; j < books.Length - 1; j++)
                {
                    if (books[j].ID > books[j + 1].ID)
                    {
                        int temp = books[j].ID;
                        books[j].ID = books[j + 1].ID;
                        books[j + 1].ID = temp;

                    }
                }
            }
            Console.WriteLine("\nSorting by ID: ");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i].ID + " ");
            }



           

           




            Console.ReadLine();
        }
    }
}
