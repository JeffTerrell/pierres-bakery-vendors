using System.Collections.Generic;

namespace PierreBakeryVendors.Models
{

  public class Vendor
  {
    private static List<Vendor> _vendorList = new List<Vendor> {};
    public string vendorName { get; set; }
    public string vendorDescription { get; set; }

    public int vendorId { get; set; }
    
    public Vendor(string name, string description)
    {
      vendorName = name;
      _vendorList.Add(this);
      vendorDescription = description;
      vendorId = _vendorList.Count;
    }

    public static List<Vendor> GetVendorList()
    {
      return _vendorList;
    }

    public static void ClearAll()
    {
      _vendorList.Clear();
    }
  }
}