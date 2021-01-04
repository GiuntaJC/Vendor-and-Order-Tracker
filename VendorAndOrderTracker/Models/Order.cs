using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int BreadAmount { get; set; }
    public int PastryAmount { get; set; }
    public string Date { get; set; }
    public int Id { get; }

    public Order(string title, string description, int price, int breadAmount, int pastryAmount, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      BreadAmount = breadAmount;
      PastryAmount = pastryAmount;
      Date = date;
    }

  }
}