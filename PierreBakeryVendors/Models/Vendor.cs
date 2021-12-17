using System.Collections.Generic;

namespace PierreBakeryVendors.Models
{

  public class Vendor
  {
    private static List<Vendor> _vendorList = new List<Vendor> {};
    public string vendorName { get; set; }
    public string vendorDescription { get; set; }
    
    public Vendor(string name, string description)
    {
      vendorName = name;
      vendorDescription = description;
      _vendorList.Add(this);
    }

    public static List<Vendor> GetVendorList()
    {
      return _vendorList;
    }
  }
}