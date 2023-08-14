using GraphQl.Data;
using GraphQl.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQl.Services
{
    [ExtendObjectType("method")]
    public class QueryType
    {
        public async Task<List<Book>> GetAllBooks([Service] ApplicationDbContext dbContext)
        {
            return await dbContext.Books.ToListAsync();
        }
    }
}
