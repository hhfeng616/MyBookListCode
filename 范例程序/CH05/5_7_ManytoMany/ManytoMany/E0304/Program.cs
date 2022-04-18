using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E0304.Model;
namespace E0304
{
    class Program
    {
        static void Main(string[] args)
        {
            KTStoreEntities entity = new KTStoreEntities();
            IEnumerable<Author> authors = from author in entity.Author
                                          select author;
            foreach (Author author in authors) {

                Console.WriteLine("{0} 著作", author.Name);

                foreach (Book book in author.Book)
                {
                    string BookAuthor = string.Format("　{0}（", book.Title);                   
                    foreach (Author bauthor in book.Author)
                    {                       
                        BookAuthor = string.Format("{0}{1} ", BookAuthor, bauthor.Name);                       
                    }
                    Console.WriteLine(string.Format("{0}）",BookAuthor.TrimEnd()));
                }
                Console.WriteLine("\n\n");
            }
            Console.ReadLine();
        }
    }
}
