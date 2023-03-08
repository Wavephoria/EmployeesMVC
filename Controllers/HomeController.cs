using EmployeesMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesMVC.Controllers;

public class HomeController : Controller
{
    private static DataService _dataService = new DataService();
    [HttpGet("")]
    public IActionResult Index()
    {
        Employee[] employees = _dataService.GetAll();
        return View(employees);
    }
    [HttpGet("/create")]
    public IActionResult CreateEmployee()
    {
        return View();
    }
    [HttpPost("/create")]
    public IActionResult CreateEmployee(Employee employee)
    {
        if (!ModelState.IsValid)
            return View();
        _dataService.AddEmployee(employee);
        return RedirectToAction(nameof(Index));
    }
}