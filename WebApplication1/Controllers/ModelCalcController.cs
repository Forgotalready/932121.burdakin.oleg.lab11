using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class ModelCalcController : Controller
{
  [NonAction]
  private Dictionary<String, String> SetData()
  {
    Random random = new Random();
    int first = (int) random.NextInt64(0, 10);
    int second = (int) random.NextInt64(0, 10);
    
    Dictionary<String, String> data = new();
    data["first"] = first.ToString();
    data["second"] = second.ToString();
    data["sum"] = (first + second).ToString();
    data["subtract"] = (first - second).ToString();
    data["mul"] = (first * second).ToString();
    data["divide"] = (second != 0) ? (first / second).ToString() : "Division by zero";
    
    return data;
  }

  public IActionResult Index()
  {
    var data = SetData();
    return View(data);
  }
}