using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL.MongoDb.Entities
{
    public class Dish : IEntity<int>
    {
        [BsonId]
        public int Id { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public double Mass { get; set; }

        public bool IsVegan { get; set; }

        public bool IsPublished { get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }

    }
}
