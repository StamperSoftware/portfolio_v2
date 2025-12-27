using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class HomeController(ITrackerService trackerService) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult> Test()
    {
        var tracker = await trackerService.AddTracker();
        return Ok(new {count = tracker.Count});
    }
}