using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDBSample1.Model;

namespace MongoDBSample1.Data
{
    public class MyWorldContext: IMyWorldContext
    {
        public   IMongoDatabase MyWorldDb { get; set; }

        public MyWorldContext(IOptions<AppSettings> options)
        {
            var mongoClient = new MongoClient(options.Value.ConnectionString);
            MyWorldDb = mongoClient.GetDatabase(options.Value.DatabaseName);
        }
    }
}
