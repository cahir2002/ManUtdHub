using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ManUtdHub.Models;

namespace ManUtdHub.Controllers;

public class ResultsController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
}
