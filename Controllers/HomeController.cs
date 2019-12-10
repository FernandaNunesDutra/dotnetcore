using Microsoft.AspNetCore.Mvc;

namespace dotnetcore.Controllers
{
    [Route("v1")]
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public string Get(){
            return "Run...";
        }
    }
}