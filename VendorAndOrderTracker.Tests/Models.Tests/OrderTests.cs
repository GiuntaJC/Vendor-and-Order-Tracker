using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_ConfirmPropertyMatchesIntendedValue_Title()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "12-18-20"); // Title, description, price, bread amount, pastry amount
      Assert.AreEqual("title", newOrder.Title);
    }
    [TestMethod]
    public void OrderConstructor_ConfirmPropertyMatchesIntendedValue_Description()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "12-18-20"); // Title, description, price, bread amount, pastry amount
      Assert.AreEqual("Description", newOrder.Description);
    }
  }
}