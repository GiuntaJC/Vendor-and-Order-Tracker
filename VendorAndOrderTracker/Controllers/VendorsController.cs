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
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor currentVendor = Vendor.Find(id);
      List<Order> currentVendorOrders = currentVendor.Orders;
      model.Add("vendor", currentVendor);
      model.Add("orders", currentVendorOrders);
      return View(model);
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
    public ActionResult Create(int vendorId, string name, int pastryAmount, int breadAmount, int price, string orderDate, string desc)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor currentVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(name, desc, price, breadAmount, pastryAmount, orderDate);
      currentVendor.AddOrder(newOrder);
      List<Order> currentVendorOrders = currentVendor.Orders;
      model.Add("vendor", currentVendor);
      model.Add("orders", currentVendorOrders);
      return View("Show", model);
    }
  }
}