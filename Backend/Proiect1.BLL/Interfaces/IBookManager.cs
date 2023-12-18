using Proiect1.Services.Models;
using System.Collections.Generic;
using Proiect1.DAL.Entities;

namespace Proiect1.Services.Interfaces
{
    public interface IBookManager
    {
        void AddBook(BookModel model);
        List<Book> GetAllBooks();
        Book GetBook(string title);
        List<Book> GetBookRecommendations();
    }
}
