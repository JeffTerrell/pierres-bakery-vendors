namespace PierreBakeryVendors.Models
{

  public class Vendor
  {

    public string vendorName { get; set; }
    public string vendorDescription { get; set; }
    public Vendor(string name, string description)
    {
      vendorName = name;
      vendorDescription = description;
    }
  }
}