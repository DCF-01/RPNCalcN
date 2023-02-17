using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RPNCalculatorN.Core;
using RPNCalculatorN.Models;

namespace RPNCalculatorN.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ServicesFacade _servicesFacade;

    public HomeController(ILogger<HomeController> logger, ServicesFacade servicesFacade)
    {
        _logger = logger;
        _servicesFacade = servicesFacade;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Calc([FromQuery] string op)
    {
        return Ok(new {result = _servicesFacade.Calc(op)});
    }
}