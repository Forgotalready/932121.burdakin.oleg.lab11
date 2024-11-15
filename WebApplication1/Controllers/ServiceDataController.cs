using Microsoft.AspNetCore.Mvc;
using WebApplication1.Service;

namespace WebApplication1.Controllers;

public class ServiceDataController : Controller
{ 
  public IActionResult Index() => View();
  
}