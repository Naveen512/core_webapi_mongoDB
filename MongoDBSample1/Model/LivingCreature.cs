using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBSample1.Model
{
    public class LivingCreature
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string CreatureName { get; set; }
        public string Home { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
