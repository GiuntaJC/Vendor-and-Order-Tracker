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
      Order newOrder = new Order("title", "Description", 19, 3, 5, "12-18-20"); // Title, description, price, bread amount, pastry amount, date
      Assert.AreEqual("title", newOrder.Title);
    }

    [TestMethod]
    public void OrderConstructor_ConfirmPropertyMatchesIntendedValue_Description()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "12-18-20"); // Title, description, price, bread amount, pastry amount, date
      Assert.AreEqual("Description", newOrder.Description);
    }

    [TestMethod]
    public void OrderConstructor_ConfirmPropertyMatchesIntendedValue_Price()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "12-18-20"); // Title, description, price, bread amount, pastry amount, date
      Assert.AreEqual(19, newOrder.Price);
    }

    [TestMethod]
    public void OrderConstructor_ConfirmPropertyMatchesIntendedValue_BreadAmount()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "12-18-20"); // Title, description, price, bread amount, pastry amount, date
      Assert.AreEqual(3, newOrder.BreadAmount);
    }

    [TestMethod]
    public void OrderConstructor_ConfirmPropertyMatchesIntendedValue_PastryAmount()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "12-18-20"); // Title, description, price, bread amount, pastry amount, date
      Assert.AreEqual(5, newOrder.PastryAmount);
    }

    [TestMethod]
    public void OrderConstructor_ConfirmPropertyMatchesIntendedValue_Date()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "12-18-20"); // Title, description, price, bread amount, pastry amount, date
      Assert.AreEqual("12-18-20", newOrder.Date);
    }
  }
}