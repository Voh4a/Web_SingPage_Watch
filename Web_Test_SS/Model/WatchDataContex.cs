using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Test_SS.Model.Interface;

namespace Web_Test_SS.Model
{
    public class WatchDataContex : IWatchContex
    {
        const string collectionName = "watches";

        public IEnumerable<Watch>  GetData(ConnectionMongoDB connection)
        {
            IMongoCollection<Watch> collection = connection.DB.GetCollection<Watch>(collectionName);
            var filter = new BsonDocument();
            var watches = collection.Find(filter).ToList();

            return watches;
        }

        public IEnumerable<Watch> GetSomeData(ConnectionMongoDB connection, int skip, int limit)
        {
            IMongoCollection<Watch> collection = connection.DB.GetCollection<Watch>(collectionName);
            var filter = new BsonDocument();
            var watches = collection.Find(filter).Skip(skip).Limit(limit).ToList();

            return watches;
        }
    }
}
