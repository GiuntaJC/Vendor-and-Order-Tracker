using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public List<Order> Orders { get; set; }
    public string VendorName { get; set; }
    public string Description { get; set; }
    public int Id { get; }
  
  public Vendor(string vendorName, string description)
  {
    VendorName = vendorName;
    Description = description;
    Orders = new List<Order>{};
  }
  public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

  }
}