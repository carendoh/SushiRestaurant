using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.MongoDb.Entities
{
    public class Drink : IEntity<int>
    {
        [BsonId]
        public int Id { get; set; }
        
        [BsonRequired]
        public string Name { get; set; }
        
        public double Price { get; set; }
        
        public string Description { get; set; }
        
        public int Volume { get; set; }
        
        public bool HasAlcohol { get; set; }
        
        public bool IsPublished { get; set; }

        public virtual IEnumerable<Ingredient> Ingredients { get; set; }
    }
}
