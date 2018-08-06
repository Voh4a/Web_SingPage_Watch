using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Test_SS.Model.Interface;

namespace Web_Test_SS.Model
{
    public class SubscribeDataContex : ISubscribeContex
    {
        const string collectionName = "users_email";

        public void Add(ConnectionMongoDB connection, SubscribeUser user)
        {
            IMongoCollection<SubscribeUser> collection = connection.DB.GetCollection<SubscribeUser>(collectionName);

            collection.InsertOne(user);
        }
    }
}
