using System.Collections.Generic;
using PersonalLibrary.Data.models;

namespace PersonalLibrary.Services
{
    public interface IBooksService
    {
        public void AddBook(Book book);
        public void DeleteBook(int bookId);
        public List<Book> GetAllBooks();
        public Book GetBook(int bookId);
    }
}