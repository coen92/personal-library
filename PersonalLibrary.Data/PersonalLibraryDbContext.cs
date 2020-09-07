using Microsoft.EntityFrameworkCore;
using PersonalLibrary.Data.models;

namespace PersonalLibrary.Data
{
    public class PersonalLibraryDbContext : DbContext
    {
        public PersonalLibraryDbContext() { }
        public PersonalLibraryDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookReview> BookReviews { get; set; }
    }
}