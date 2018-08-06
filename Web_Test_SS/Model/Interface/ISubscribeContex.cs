using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Test_SS.Model.Interface
{
    public interface ISubscribeContex
    {
        void Add(ConnectionMongoDB connection, SubscribeUser user);
    }
}
