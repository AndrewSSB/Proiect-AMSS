using BookHub.Services.Models;
using System.Collections.Generic;
using BookHub.DAL.Entities;

namespace BookHub.Services.Interfaces
{
    public interface IBookManager
    {
        void AddBook(BookModel model);
        List<Book> GetAllBooks();
        Book GetBook(string title);
        List<Book> GetBookRecommendations();
    }
}
