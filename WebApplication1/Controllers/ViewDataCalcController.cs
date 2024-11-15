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
    ViewData["mul"] = first * second;
    if (second != 0)
    {
      ViewData["divide"] = first / second;
    }
    else
    {
      ViewData["divide"] = "Division by zero";
    }
  }

  public IActionResult Index()
  {
    SetData();
    return View();
  }
}