using System.Collections.Generic; 

namespace OrderTracker.Models
{
  public class Vendor
  {
    private static List<Order> _vendorInstances = new List<Order> { };
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName; 
      _vendorInstances.Add(this); 
      Id = _vendorInstances.Count; 
      Orders = new List<Order>{}; 
    }

    public static void ClearAll()
    {
      _vendorInstances.Clear(); 
    }

    public static List<Vendor> GetAll()
    {
      return _vendorInstances; 
    }

    public static Vendor Find(int searchId)
    {
      return _vendorInstances[searchId-1]; 
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order); 
    }
  }
}