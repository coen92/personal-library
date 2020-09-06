using System;
using System.Collections.Generic;
using System.Linq;
using PersonalLibrary.Data;
using PersonalLibrary.Data.models;

namespace PersonalLibrary.Services
{
    public class BooksService : IBooksService
    {
        private readonly PersonalLibraryDbContext _dbContext;
        public BooksService(PersonalLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBook(Book book)
        {
            _dbContext.Add(book);
            _dbContext.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            var book = _dbContext.Books.Find(bookId);
            if (book != null)
            {
                _dbContext.Remove(book);
            }
            throw new InvalidOperationException("Invalid book id: " + $"{bookId}" + ". It doesn't exist in database");
        }

        //Todo: introduce some Pagination here later to reduce the data load
        public List<Book> GetAllBooks()
        {
            return _dbContext.Books.ToList();
        }

        public Book GetBook(int bookId)
        {
            return _dbContext.Books.Find(bookId);
        }
    }
}