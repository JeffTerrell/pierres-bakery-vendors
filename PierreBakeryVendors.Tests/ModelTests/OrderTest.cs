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
      Order newOrder = new Order(orderTitle);

      //Act
      string result = newOrder.orderTitle;

      //Assert
      Assert.AreEqual(orderTitle, result);
    }
  }  
}