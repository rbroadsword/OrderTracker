using System.Collections.Generic; 

namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Date { get; set; }
  

    public Order(string description, string title)
    {
      Title = title; 
      Description = description; 
      //Price = price; 
      //Date = date; 
    }


  }
}