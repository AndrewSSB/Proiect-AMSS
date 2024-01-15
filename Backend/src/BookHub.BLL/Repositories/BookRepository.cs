using System.Linq;
using BookHub.BLL.Interfaces;
using BookHub.DAL;
using BookHub.DAL.Entities;

namespace BookHub.BLL.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext db;

        public BookRepository(AppDbContext db)
        {
            this.db = db;
        }

        public void AddBook(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }

        public IQueryable<Book> GetBooksIQueryable()
        {
            var books = db.Books.OrderByDescending(x => x.Id);
            return books;
        }

        public IQueryable<Book> GetBooksRecommendationsIQueryable()  //obs-> returneaxa primele 2 carti 
        {
            var books = db.Books.OrderByDescending(x => x.PublishDate);
            return books.Take(2);
        }

        public Book GetBook(string title)
        {
            var book = db.Books
                .FirstOrDefault(x => x.Title == title);

            return book;
        }


    }
}
