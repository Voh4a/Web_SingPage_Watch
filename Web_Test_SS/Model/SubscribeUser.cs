using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Test_SS.Model
{
    public class SubscribeUser
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string email { get; set; }

        public SubscribeUser(string _email)
        {
            email = _email;
        }
    }
}
