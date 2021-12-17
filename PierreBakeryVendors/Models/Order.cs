namespace PierreBakeryVendors.Models
{
  public class Order
  {
    public string orderTitle { get; set;}

    public Order(string title)
    {
      orderTitle = "Order-001";
    }
  }
}