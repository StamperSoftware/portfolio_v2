using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class HomeController : BaseApiController
{
    [HttpGet]
    public ActionResult<Task> Test()
    {
        return Ok(new {connected=true});
    }
}