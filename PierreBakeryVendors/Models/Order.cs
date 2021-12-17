namespace PierreBakeryVendors.Models
{
  public class Order
  {
    public string orderTitle { get; set; }
    public string orderDescription { get; set; }

    public Order(string title, string description)
    {
      orderTitle = title;
      orderDescription = description;
    }
  }
}