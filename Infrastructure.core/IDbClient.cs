using Domain.core;
using MongoDB.Driver;

namespace Infrastructure.core
{
    public interface IDbClient
    {
        IMongoCollection<Book> GetBookCollection();
    }
}
