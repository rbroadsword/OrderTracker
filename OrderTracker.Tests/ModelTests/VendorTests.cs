using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.TestTools
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll(); 
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description"); 
      Assert.AreEqual(typeof(Vendor), newVendor.GetType()); 
    }

      [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      string description = "test description"; 
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor newVendor1 = new Vendor("test name", "test description");
      Vendor newVendor2 = new Vendor("test name", "test description");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

        [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("test name", "test description");
      Vendor newVendor2 = new Vendor("test name", "test description");

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }
  }
}