using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Domain.core
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
    }
}
