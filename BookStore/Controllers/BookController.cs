using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
     
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
       public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public List<BookModel> GetAllBook()
        {
            return _bookRepository.GetAllBooks();
        }
        public BookModel GetBook(int Bookid)
        {
            return _bookRepository.GetBookByID(Bookid);

        }
        public List<BookModel>SearchBook(string Title, string Auther)
        {
            return _bookRepository.SearchBook(Title, Auther);

        }
    }
}
