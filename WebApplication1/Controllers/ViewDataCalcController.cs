using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class ViewDataCalcController : Controller
{

  [NonAction]
  private void SetData()
  {
    Random random = new Random();
    int first = (int) random.NextInt64(0, 10);
    int second = (int) random.NextInt64(0, 10);
    
    ViewData["first"] = first;
    ViewData["second"] = second;
    ViewData["sum"] = first + second;
    ViewData["subtract"] = first - second;
    ViewData["mul"] = first * second;
    ViewData["divide"] = (second != 0) ? first / second : "Division by zero";
  }

  public IActionResult Index()
  {
    SetData();
    return View();
  }
}