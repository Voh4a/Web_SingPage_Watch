﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Test_SS.Model
{
    public class Watch
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public int price { get; set; }
    }
}
