using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMongoDb.Data.Entities
{
    public class MongoEntity : IMongoEntity
    {
        [BsonId]
        public MongoDB.Bson.ObjectId Id { get; set; }
    }
}
