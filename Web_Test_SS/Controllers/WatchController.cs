using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Test_SS.Model;

namespace Web_Test_SS.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class WatchController : Controller
    {
        // GET api/watch
        [HttpGet]
        public IEnumerable<Watch> Get()
        {
            Watches watches = new Watches(new WatchDataContex());

            return watches.GetWatches();
        }

        // GET api/watch
        [HttpGet("{skip}/{limit}")]
        public IEnumerable<Watch> GetSome(int skip, int limit)
        {
            Watches watches = new Watches(new WatchDataContex());

            IEnumerable<Watch> test = watches.GetSomeWatches(skip, limit);
            return test;
        }
    }
}