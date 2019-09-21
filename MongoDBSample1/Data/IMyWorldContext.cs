using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MongoDBSample1.Data
{
    public interface IMyWorldContext
    {
        IMongoDatabase MyWorldDb { get; }
    }
}
