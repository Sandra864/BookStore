using Domain.core;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Book> _books;
        public DbClient(IOptions<BookStoreDBConfig> bookStoreDbConfig)
        {
            var client = new MongoClient(bookStoreDbConfig.Value.Connection_String);
            var dataBase = client.GetDatabase(bookStoreDbConfig.Value.DataBase_Name);
            _books = dataBase.GetCollection<Book>(bookStoreDbConfig.Value.Books_Collection_Name);

        }
        public IMongoCollection<Book> GetBookCollection() => _books;
    }
}
