using BookHub.DAL.Entities;
using System.Linq;

namespace BookHub.BLL.Interfaces
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        IQueryable<Book> GetBooksIQueryable();
        IQueryable<Book> GetBooksRecommendationsIQueryable();
        Book GetBook(string title);
    }
}
