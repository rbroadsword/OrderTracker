using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.TestTools
{
  [TestClass]
  public class OrderTests 
  {

    // public void Dispose()
    // {
    //   Category.ClearAll();
    // }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test order"); 
      Assert.AreEqual(typeof(Order), newOrde.GetType()); 
    }
  }
}