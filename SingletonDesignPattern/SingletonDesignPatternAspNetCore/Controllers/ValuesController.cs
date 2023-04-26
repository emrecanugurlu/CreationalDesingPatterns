using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SingletonDesignPatternAspNetCore.Services;

namespace SingletonDesignPatternAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult X()
        {
            var dbServiceInstance = DbService.GetInstance;
            dbServiceInstance.Connection();
            dbServiceInstance.DeConnection();
            return Ok(dbServiceInstance.Count);
        }


        [HttpGet("[action]")]
        public IActionResult Y()
        {
            var dbServiceInstance = DbService.GetInstance;
            dbServiceInstance.Connection();
            dbServiceInstance.DeConnection();
            return Ok(dbServiceInstance.Count);
        }
    }
}
