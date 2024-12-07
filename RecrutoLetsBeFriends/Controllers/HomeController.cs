using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RecrutoLetsBeFriends.Models;

namespace RecrutoLetsBeFriends.Controllers;

//[Route("[controller]")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //[HttpGet("Index")]
    [HttpGet]
    public IActionResult Index([FromQuery] string name, [FromQuery] string message)
    {
        var model = new MessageModel(name, message);
        
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}