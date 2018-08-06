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
    public class SubscribeController : Controller
    {
        // Post api/subscribe
        [HttpPost("{email}")]
        public void Post(string email)
        {
            SubscribeUsers subUsers = new SubscribeUsers(new SubscribeDataContex());

            subUsers.AddSubscribeUser(new SubscribeUser(email));
        }
    }
}