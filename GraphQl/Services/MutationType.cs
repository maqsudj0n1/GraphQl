using GraphQl.Data;
using GraphQl.Models;
namespace GraphQl.Services
{
    public class MutationType
    {
        public async Task<Book> CreateBook([Service]ApplicationDbContext context, Book book)
        {
            context.Books.Add(book);
            await context.SaveChangesAsync();
            return book;
        }
        public async Task<Author> CreateAuthor([Service] ApplicationDbContext context, Author author)
        {
            context.Authors.Add(author);
            await context.SaveChangesAsync();
            return author;
        }
        public async Task<Book> UpdateBook([Service]ApplicationDbContext context, Book book)
        {
            context.Books.Update(book);
            await context.SaveChangesAsync();
            return book;
        }
        public async Task<Author> UpdateAuthor([Service]ApplicationDbContext context, Author author)
        {
            context.Authors.Update(author);
            await context.SaveChangesAsync();
            return author;
        }
        public async Task<string> DeleteBook([Service] ApplicationDbContext context,  int bookId)
        {
            context.Books.Remove(context.Books.Find(bookId));
            await context.SaveChangesAsync();
            return "Deleted";
        }
        public async Task<string> DeleteAuthor([Service] ApplicationDbContext context, int authorId)
        {
            context.Authors.Remove(context.Authors.Find(authorId));
            await context.SaveChangesAsync();
            return "Deleted";
        }
    }
}
