using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class ViewBagCalcController : Controller
{
  [NonAction]
  private void SetData()
  {
    Random random = new Random();
    int first = (int) random.NextInt64(0, 10);
    int second = (int) random.NextInt64(0, 10);
    
    ViewBag.first = first;
    ViewBag.second = second;
    ViewBag.sum = first + second;
    ViewBag.mul = first * second;
    if (second != 0)
    {
      ViewBag.divide = first / second;
    }
    else
    {
      ViewBag.divide = "Division by zero";
    }
  }

  public IActionResult Index()
  {
    SetData();
    return View();
  }
}