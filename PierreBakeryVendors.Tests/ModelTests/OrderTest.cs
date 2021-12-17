using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierreBakeryVendors.Models;

namespace PierreBakeryVendors.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      //Arrange
      string orderTitle = "Test Order";
      Order newOrder = new Order(orderTitle, "Order Description");

      //Act
      string result = newOrder.orderTitle;

      //Assert
      Assert.AreEqual(orderTitle, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      //Arrange
      string orderDescription = "Test Description";
      Order newOrder = new Order("Order Title", orderDescription);

      //Act
      string result = newOrder.orderDescription;

      //Assert
      Assert.AreEqual(orderDescription, result);
    }
  }  
}