using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_ConfirmIdIsAssignedToVendor_Id()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe", "Description"); // VendorName, description

      int result = newVendor.Id;
      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void VendorConstructor_ConfirmPropertyMatchesIntendedValue_VendorName()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe", "Description"); // VendorName, description

      string result = newVendor.VendorName;

      Assert.AreEqual("Suzie's Cafe", result);
    }

    [TestMethod]
    public void VendorConstructor_ConfirmPropertyMatchesIntendedValue_Description()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe", "Description"); // VendorName, description

      string result = newVendor.Description;

      Assert.AreEqual("Description", result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Order newOrder = new Order("title", "Description", 19, 3, 5, "2020-12-18"); // Title, description, price, bread amount, pastry amount, date
      Vendor newVendor = new Vendor("Suzie's Cafe", "Description"); // VendorName, description
      List<Order> newList = new List<Order> { newOrder };
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;


      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe", "Description"); // VendorName, description
      List<Vendor> newList = new List<Vendor> {newVendor};

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(result, newList);
    }

    [TestMethod]
    public void Find_ReturnsAllVendors_Vendor()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe", "Description"); // VendorName, description
      Vendor otherVendor = new Vendor("Some Other Guy", "Description"); // VendorName, description

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(result, otherVendor);
    }

  }
}