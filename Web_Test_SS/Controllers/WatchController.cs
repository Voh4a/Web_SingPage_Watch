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
            List<Watch> watches = new List<Watch>();

            Watch watch = new Watch
            {
                Image = "../Content/WatchesImage/HamiltonH76512733.jpg",
                Name = "Hamilton H76512733",
                Text = "Виробник: Швейцарія / механізм: кварцовий / стікло: сапфіровое / тип індикації: стрілковий / корпус: сталь / водонепроникність: 100 м / ремінь: шкіряний / тип: чоловічі",
                Price = 16900
            };

            watches.Add(watch);

            watch = new Watch
            {
                Image = "../Content/WatchesImage/HamiltonH82305931.jpg",
                Name = "Hamilton H82305931",
                Text = "Виробник: Швейцария / механізм: механічний з автоподзаводом / стікло: сапфіровое / тип індикацхї: стрілковий / корпус: сталь / водонепроникність: 100 м / ремінь: тканинний / тип: чоловічі",
                Price = 21850
            };

            watches.Add(watch);

            watch = new Watch
            {
                Image = "../Content/WatchesImage/Atlantic50744.41.21.jpg",
                Name = "Atlantic 50744.41.21",
                Text = "Виробник: Швейцарія / тип: чоловічі / механізм: механічний с автоподзаводом / стікло: сапфіровое / тип індикацхї: стрілковий / корпус: сталь / водонепроникність: 50 м / ремінь: шкіряний",
                Price = 15370
            };

            watches.Add(watch);

            return watches;

        }
    }
}