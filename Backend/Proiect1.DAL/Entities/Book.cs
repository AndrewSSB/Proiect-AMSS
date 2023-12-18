using System.Collections.Generic;

namespace Proiect1.DAL.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string PublishDate { get; set; }
        public string ImagePath { get; set; }
       // public virtual ICollection<Review> Reviews { get; set; }
    }
}
