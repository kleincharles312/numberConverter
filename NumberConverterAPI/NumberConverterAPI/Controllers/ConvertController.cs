using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NumberConverterAPI.Models;
using NumberConverterAPI.Service;


namespace NumberConverterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConvertController : ControllerBase
    {
        [HttpGet]
        [EnableCors]
        public ActionResult<ReturnedNumbers> GetConvert(string number, string type)
        {
            // TODO: use error handling here before calling ConverterHub
            ConverterHub hub = new ConverterHub(number, type);
            ReturnedNumbers result = hub.PerformConversion();

            return Ok(result);
        }
    }
}