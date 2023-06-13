using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class PrimeiraController : ControllerBase
    {
        [HttpGet("primeiro")]
        public string pirmeiroEndPoint()
        {
            return "AUla de restapi";   
        }

    }
}
