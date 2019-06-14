using DataAccess;
using Entities;
using System.Data;

namespace BussinessLogic
{
    public class BookBus
    {
        BookDao bookDao = new DataAccess.BookDao();
        public DataTable LoadBooks()
        {
            return bookDao.LoadBooks();
        }
        public void InsertBook(BookEntiy book)
        {
            if (string.IsNullOrEmpty(book.Name))
            {
                book.Name = "";
            }
            if (string.IsNullOrEmpty(book.Author))
            {
                book.Author = "";
            }
            if (string.IsNullOrEmpty(book.Note))
            {
                book.Note = "";
            }
            bookDao.InsertBook(book);
        }
        public void UpdateBook(BookEntiy book)
        {
            if (string.IsNullOrEmpty(book.Name))
            {
                book.Name = "";
            }
            if (string.IsNullOrEmpty(book.Author))
            {
                book.Author = "";
            }
            if (string.IsNullOrEmpty(book.Note))
            {
                book.Note = "";
            }
            bookDao.InsertBook(book);
        }
        public void DeleteBook(int bookId)
        {
            if (bookId != 0)
            {
                bookDao.DeleteBook(bookId);
            }
        }
        public DataTable GetBooksById(int bookId)
        {
            return bookDao.GetBooksById(bookId);
        }
        public DataTable GetBooksByName(string keyword)
        {
            return bookDao.GetBooksByName(keyword);
        }
    }
}
