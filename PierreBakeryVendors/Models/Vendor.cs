using System.Collections.Generic;

namespace PierreBakeryVendors.Models
{

  public class Vendor
  {
    private static List<Vendor> _vendorList = new List<Vendor> {};
    public string vendorName { get; set; }
    public string vendorDescription { get; set; }

    public int vendorId { get; set; }

    public List<Order> Orders { get; set; }
    
    public Vendor(string name, string description)
    {
      vendorName = name;
      _vendorList.Add(this);
      vendorDescription = description;
      vendorId = _vendorList.Count;
      Orders = new List<Order> {};
    }

    public static List<Vendor> GetVendorList()
    {
      return _vendorList;
    }

    public static Vendor Find(int searchId)
    {
      return _vendorList[searchId - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static void ClearAll()
    {
      _vendorList.Clear();
    }
    
  }
}