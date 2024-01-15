using BookHub.BLL.Interfaces;
using BookHub.DAL.Entities;
using BookHub.Services.Interfaces;
using BookHub.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookHub.BLL.Managers
{
    public class BookManager : IBookManager
    {
        private readonly IBookRepository bookRepository;

        public BookManager(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public void AddBook(BookModel model)
        {
            var newBook = new Book
            {
                Title = model.Title,
                Author = model.Author,
                Description = model.Description,
                ImagePath = model.ImagePath,
                PublishDate = model.PublishDate
            };
            bookRepository.AddBook(newBook);
        }

        public List<Book> GetAllBooks()
        {
            return bookRepository.GetBooksIQueryable().ToList();
        }

        public Book GetBook(string title)
        {
            return bookRepository.GetBook(title);
        }

        public List<Book> GetBookRecommendations()
        {
            return bookRepository.GetBooksRecommendationsIQueryable().ToList();
        }
    }
}
