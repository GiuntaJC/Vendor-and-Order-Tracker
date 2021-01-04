using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
  public class VendorsController : Controller
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

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor currentVendor = Vendor.Find(id);
      List<Order> orderList = currentVendor.Orders;
      return View(currentVendor);
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderName, int breadCount, int pastryCount, int price, string orderDate, string orderDescription)
    {
      Vendor currentVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderName, orderDescription, price, breadCount, pastryCount, orderDate);
      currentVendor.AddOrder(newOrder);
      List<Order> orderList = currentVendor.Orders;
      return RedirectToAction("Index");
    }
  }
}