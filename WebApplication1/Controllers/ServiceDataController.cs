using Microsoft.AspNetCore.Mvc;
using WebApplication1.Service;

namespace WebApplication1.Controllers;

public class ServiceDataController : Controller
{
  private readonly CalculationService _calculationService;

  public ServiceDataController(CalculationService calculationService)
  {
    _calculationService = calculationService;
  }
  
  [NonAction]
  private void SetData()
  {
    var data = _calculationService.Calculate();
    ViewData["first"] = data["first"];
    ViewData["second"] = data["second"];
    ViewData["sum"] = data["sum"];
    ViewData["mul"] = data["mul"];
    ViewData["divide"] = data["divide"];
  }

  public IActionResult Index()
  {
    SetData();
    return View();
  }
}