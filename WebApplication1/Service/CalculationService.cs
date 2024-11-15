namespace WebApplication1.Service;

public class CalculationService
{
  public Dictionary<String, String> Calculate()
  {
    Random random = new Random();
    int first = (int) random.NextInt64(0, 10);
    int second = (int) random.NextInt64(0, 10);
    
    Dictionary<String, String> data = new();
    data["first"] = first.ToString();
    data["second"] = second.ToString();
    data["sum"] = (first + second).ToString();
    data["mul"] = (first * second).ToString();
    if (second != 0)
    {
      data["divide"] = (first / second).ToString();
    }
    else
    {
      data["divide"] = "Division by zero";
    }

    return data;
  }
}