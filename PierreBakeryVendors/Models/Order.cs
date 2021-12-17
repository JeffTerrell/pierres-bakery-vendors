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
    public int orderId { get; }

    public Order(string title, string description, string date, int price)
    {
      orderTitle = title;
      _orderList.Add(this);
      orderDescription = description;
      orderDate = date;
      orderPrice = price;
      orderId = _orderList.Count;
    }

    public static List<Order> GetOrderList()
    {
      return _orderList;
    }

    public static Order Find(int searchId)
    {
      return _orderList[searchId - 1];
    }
    public static void ClearAll()
    {
      _orderList.Clear();
    }
  }
}