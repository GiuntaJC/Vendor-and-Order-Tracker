using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int orderId)
    {
      Order currentOrder = Order.Find(orderId);
      return View(currentOrder);
    }
  }
}