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
      Order newOrder = new Order("title", "Description", 19, 3, 5, "2020-12-18"); // Title, description, price, bread amount, pastry amount, date
      Vendor newVendor = new Vendor("Suzie's Cafe", "Description", newOrder); // VendorName, description, Order list
      Assert.AreEqual("Suzie's Cafe", newVendor.VendorName);
    }

  }
}