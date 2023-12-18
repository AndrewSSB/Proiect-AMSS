using Proiect1.DAL.Entities;
using System.Linq;

namespace Proiect1.BLL.Interfaces
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        IQueryable<Book> GetBooksIQueryable();
        IQueryable<Book> GetBooksRecommendationsIQueryable();
        Book GetBook(string title);
    }
}
