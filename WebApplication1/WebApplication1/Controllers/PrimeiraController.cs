using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")] // fica Primeira, se fosse
    //sem o conchete seria apenas a palavra controller
    public class PrimeiraController : ControllerBase
    {
        [HttpGet("primeiro")]
        public string pirmeiroEndPoint()
        {
            return "AUla de restapi";   
        }

    }
}
