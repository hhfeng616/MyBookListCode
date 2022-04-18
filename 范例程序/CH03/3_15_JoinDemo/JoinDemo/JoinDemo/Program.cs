using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //// join
            //var cbooks =
            //     from c in categories
            //     join b in books on
            //     c.Id equals b.CategoryId
            //     select new
            //     {
            //         BookCategory = c.Name,
            //         BookTitle = b.Name
            //     };

            // Join Method
            //var cbooks = categories.Join(books,
            //    c => c.Id,
            //    b => b.CategoryId,
            //    (c, b) => new
            //    {
            //        BookCategory = c.Name,
            //        BookTitle = b.Name
            //    });

            //foreach (var book in cbooks)
            //{
            //    Console.WriteLine("书籍分类：{0}\t书名：{1}",
            //        book.BookCategory.PadLeft(8), book.BookTitle);
            //}




            ////groupjoin

            IEnumerable<IEnumerable<Book>> cbooks =
            from c in categories
            join b in books on
            c.Id equals b.CategoryId
            into bgroup
            select bgroup;

            foreach (var cb in cbooks)
            {
                foreach (var c in cb)
                {
                    Console.WriteLine("{0}\t{1}", c.CategoryId, c.Name);
                }
                Console.WriteLine("---------------------------------------------");
            }



            ////groupjoin-new

            //var cbooks =
            //  from c in categories
            //  join b in books on
            //  c.Id equals b.CategoryId
            //  into bgroup
            //  select new
            //  {
            //      GCategory = c.Name,
            //      GBook = from b in bgroup
            //              select b
            //  };


            ////groupjoin-new-method
            //var cbooks = categories.GroupJoin(
            //    books,
            //    c => c.Id,
            //    b => b.CategoryId,
            //    (c, bgroup) => new { GCategory = c.Name, GBook = bgroup });



            //foreach (var cb in cbooks)
            //{
            //    Console.WriteLine("\n{0}\n", cb.GCategory);
            //    foreach (var c in cb.GBook)
            //    {
            //        Console.WriteLine("{0}\t{1}", c.CategoryId, c.Name);
            //    }

            //}


            Console.ReadKey();
        }
        //Category
        static List<Category> categories = new List<Category>()
        {
            new Category()
            {Name="ASP.NET", Id=001},
           new Category()
            {Name=".NET", Id=002},
            new Category()
            {Name="Web", Id=003},
              new Category()
            {Name="Mobile", Id=004}

        };
        //Book
        static List<Book> books = new List<Book>()
        {
            new Book()
            {Name="ASP.NET MVC 商业应用开发实践", CategoryId=001},
            new Book()
            {Name="ASP.NET MVC 实用精解", CategoryId=001},
            new Book()
            {Name="Entity Framework 实用精解", CategoryId=002},
            new Book()
            {Name="C# 实用精解", CategoryId=002},
            new Book()
            {Name="HTML5从零开始", CategoryId=003},
            new Book()
            {Name="HTML5完美风暴", CategoryId=003},
            new Book()
            {Name="React 入门", CategoryId=003},
            new Book()
            {Name="ReactX 专业手册", CategoryId=005}
        };
    }

    class Book
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
    class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

}



