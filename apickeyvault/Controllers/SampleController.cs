using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apickeyvault.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly IConfiguration configuration; 
        public SampleController(IConfiguration configuration)
        {
            this.configuration = configuration;     
        }

        [HttpGet]
        public List<string> Get()
        {
            List<string> result = new List<string>() {
                configuration["dbConn"]
            };
            return result;
        }
    }
}
