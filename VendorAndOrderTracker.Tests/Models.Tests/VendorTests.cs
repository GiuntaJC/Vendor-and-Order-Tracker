using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_ConfirmPropertyMatchesIntendedValue_VendorName()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe", "Description"); // VendorName, description, Order list

      string result = newVendor.VendorName;

      Assert.AreEqual("Suzie's Cafe", result);
    }

    [TestMethod]
    public void VendorConstructor_ConfirmPropertyMatchesIntendedValue_Description()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe", "Description"); // VendorName, description, Order list

      string result = newVendor.Description;

      Assert.AreEqual("Description", result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "2020-12-18"); // Title, description, price, bread amount, pastry amount, date
      Vendor newVendor = new Vendor("Suzie's Cafe", "Description"); // VendorName, description, Order list
      List<Order> newList = new List<Order> { newOrder };
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;


      CollectionAssert.AreEqual(newList, result);
    }

  }
}