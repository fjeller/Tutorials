using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcTest.Data.Postgres.Repositories;
using MvcTest.Models;

namespace MvcTest.Controllers;

public class HomeController : Controller
{
    private readonly IMachineRepository _repository;

    public HomeController(IMachineRepository repository)
    {
	    _repository = repository;
    }

    public IActionResult Index()
    {
        var machines = _repository.GetMachines();

        return View(machines);
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