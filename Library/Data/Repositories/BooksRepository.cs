using Library.Data;
using Library.Data.Entities;

namespace Library.Data.Repositories
{
    public class BooksRepository
    {
        private readonly AppDbContext _dbContext;

        public BooksRepository(AppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public List<Book> GetAllBooks()
        {
            return _dbContext.Books.ToList();
        }

        public Book? GetBook(Guid id)
        {
            return _dbContext.Books.Find(id);
        }

        public void AddBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _dbContext.Books.Update(book);
            _dbContext.SaveChanges();
        }

        public void DeleteBook(Guid id)
        {
            var book = _dbContext.Books.Find(id);
            if (book != null) 
            {
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }
        }
    }
}
