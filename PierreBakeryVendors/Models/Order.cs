using System;
using System.Collections.Generic;

namespace PierreBakeryVendors.Models
{
  public class Order
  {
    private static List<Order> _orderList = new List<Order> {};
    public string orderTitle { get; set; }
    public string orderDescription { get; set; }
    public string orderDate { get; set; }
    public int orderPrice { get; set; }

    public Order(string title, string description, string date, int price)
    {
      orderTitle = title;
      orderDescription = description;
      orderDate = date;
      orderPrice = price;
    }

    public static List<Order> GetOrderList()
    {
      return _orderList;
    }
  }
}