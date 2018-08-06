using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Web_Test_SS.Model
{
    public class ConnectionMongoDB
    {
       public IMongoDatabase DB { get; set; }

       public  ConnectionMongoDB(string connectionString, string dbName)
        {
            try
            {
                MongoClient client = new MongoClient(connectionString);
                DB = client.GetDatabase(dbName);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
