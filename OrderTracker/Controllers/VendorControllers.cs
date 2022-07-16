using System.Collections.Generic; 
using System; 
using Microsoft.AspNetCore.Mvc; 
using OrderTracker.Models; 

namespace OrderTracker.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll(); 
      return View(allVendors); 
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View(); 
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName); 
      return RedirectToAction("Index"); 
    }


  }
}