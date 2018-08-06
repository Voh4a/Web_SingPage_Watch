using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Test_SS.Model.Interface
{
    public interface IWatchContex
    {
        IEnumerable<Watch> GetData(ConnectionMongoDB connection);
    }
}
