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
      Order newOrder = new Order(orderTitle, "Order Description", "01/01/2011");

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
      Order newOrder = new Order("Order Title", orderDescription, "01/01/2011");

      //Act
      string result = newOrder.orderDescription;

      //Assert
      Assert.AreEqual(orderDescription, result);
    }

    [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_String()
    {
      //Arrange
      string orderDate = "07/20/2021";
      Order newOrder = new Order("Order Title", "Order Description", orderDate);

      //Act
      string result = newOrder.orderDate;

      //Assert
      Assert.AreEqual(orderDate, result);
    }
  }  
}