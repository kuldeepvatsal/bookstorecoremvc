using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookByID(int bookid) 
        {

            return DataSource().Where(x => x.bookid == bookid).FirstOrDefault();
        }
        public List<BookModel>SearchBook(string Title,string autherNamer)
        {
            return DataSource().Where(x => x.BookName.Contains(Title) || x.bookAuther.Contains(autherNamer)).ToList();
        }

        private List<BookModel>DataSource()
        {
            return new List<BookModel>()
            { 
             new BookModel(){ bookid=1,BookName="Mvc",bookAuther="kuldeep"},
             new BookModel(){ bookid=2,BookName="C#",bookAuther="Virendra"},
             new BookModel(){ bookid=3,BookName="Angular",bookAuther="Ajit"},
            new BookModel(){ bookid=4,BookName="Sql",bookAuther="Kanchan"},
            new BookModel(){ bookid=5,BookName="React",bookAuther="Pavan"},
            new BookModel(){ bookid=6,BookName="DesginPattern",bookAuther="Singh"},

            };

        }
    }
}
