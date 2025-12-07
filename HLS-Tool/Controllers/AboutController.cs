using Microsoft.AspNetCore.Mvc;

namespace HLS_Tool.Controllers;

public class AboutController : Controller
{

    public IActionResult Index()
    {
        return View(); 
    }
    
}