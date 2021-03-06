using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendorAndOrderTracker.Models;
namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_ConfirmPropertyMatchesIntendedValue_Title()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "2020-12-18"); // Title, description, price, bread amount, pastry amount, date

      string result = newOrder.Title;
      
      Assert.AreEqual("title", result);
    }

    [TestMethod]
    public void OrderConstructor_ConfirmPropertyMatchesIntendedValue_Description()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "2020-12-18"); // Title, description, price, bread amount, pastry amount, date

      string result = newOrder.Description;

      Assert.AreEqual("Description", result);
    }

    [TestMethod]
    public void OrderConstructor_ConfirmPropertyMatchesIntendedValue_Price()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "2020-12-18"); // Title, description, price, bread amount, pastry amount, date

      int result = newOrder.Price;

      Assert.AreEqual(19, result);
    }

    [TestMethod]
    public void OrderConstructor_ConfirmPropertyMatchesIntendedValue_BreadAmount()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "2020-12-18"); // Title, description, price, bread amount, pastry amount, date

      int result = newOrder.BreadAmount;

      Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void OrderConstructor_ConfirmPropertyMatchesIntendedValue_PastryAmount()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "2020-12-18"); // Title, description, price, bread amount, pastry amount, date

      int result = newOrder.PastryAmount;

      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void OrderConstructor_ConfirmPropertyMatchesIntendedValue_Date()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "2020-12-18"); // Title, description, price, bread amount, pastry amount, date

      string result = newOrder.Date;

      Assert.AreEqual("2020-12-18", result);
    }

    [TestMethod]
    public void Find_ReturnsChosenOrder_Order()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "2020-12-18"); // Title, description, price, bread amount, pastry amount, date
      Order otherOrder = new Order("other title", "other Description", 19, 3, 5, "2021-1-4"); // Title, description, price, bread amount, pastry amount, date

      Order result = Order.Find(2);

      Assert.AreEqual(result, otherOrder);
    }
  }
}