using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Test_SS.Model.Interface;

namespace Web_Test_SS.Model
{
    public class SubscribeUsers
    {
        private ISubscribeContex contex;
        private ConnectionMongoDB connection;
        const string connectionDB = "mongodb://Volodia:dfczgkfdtwm2@ds113442.mlab.com:13442/test_watch";
        const string dbName = "test_watch";

        public SubscribeUsers(ISubscribeContex _contex)
        {
            contex = _contex;
            connection = new ConnectionMongoDB(connectionDB, dbName);
        }

        public void AddSubscribeUser(SubscribeUser user)
        {
            contex.Add(connection, user);
        }
    }
}
