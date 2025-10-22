using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Configuration_Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigDemoController : ControllerBase
    {
        private readonly IConfiguration _configuration; 
        public ConfigDemoController(IConfiguration configuration)
        {
            _configuration = configuration; 
        }
        [HttpGet]
        public IActionResult GetAppSettings()
        {
            var appName = _configuration["AppSettings:ApplicationName"];
            var version= _configuration["AppSettings:Version"];
            return Ok(new {appName, version});  
        }
    }
}
