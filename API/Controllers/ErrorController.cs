using API.Errors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("errors/{code}")]
    [ApiExplorerSettings(IgnoreApi = true)]       //this is used so that we can see all the apis documented in swagger 
    public class ErrorController : BaseAPIController                      //instead of this controller
    {
        public IActionResult Error(int code)
        {
            return new ObjectResult(new APIResponse(code));
        }
    }
}