using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.MongoDb.Entities
{
    public class Category : IEntity<int>
    {
        [BsonId]
        public int Id { get; set; }
        
        [BsonRequired]
        public string Name { get; set; }

        public virtual IEnumerable<Dish> Dishes { get; set; }
    }
}
