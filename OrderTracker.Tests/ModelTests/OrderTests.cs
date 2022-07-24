using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.TestTools
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test order", "test description", "test date", "test price"); 
      Assert.AreEqual(typeof(Order), newOrder.GetType()); 
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Test Title"; 
      string description = "test description"; 
      string date = "Jan 1, 2022"; 
      string price = "100"; 

      Order newOrder = new Order(title, description, date, price); 
      string result = newOrder.Title; 

      Assert.AreEqual(title, result); 
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string title = "Test Title"; 
      string description = "test description"; 
      string date = "Jan 1, 2022"; 
      string price = "100"; 

      Order newOrder = new Order(title, description, date, price); 
      string result = newOrder.Description; 

      Assert.AreEqual(description, result); 
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string title = "Test Title"; 
      string description = "test description"; 
      string date = "Jan 1, 2022"; 
      string price = "100"; 

      Order newOrder = new Order(title, description, date, price); 
      string result = newOrder.Date; 

      Assert.AreEqual(date, result); 
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_String()
    {
      string title = "Test Title"; 
      string description = "test description"; 
      string date = "Jan 1, 2022"; 
      string price = "100"; 

      Order newOrder = new Order(title, description, date, price); 
      string result = newOrder.Price; 

      Assert.AreEqual(price, result); 
    }
  }
}