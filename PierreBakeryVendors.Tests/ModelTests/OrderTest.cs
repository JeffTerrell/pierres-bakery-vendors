using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierreBakeryVendors.Models;

namespace PierreBakeryVendors.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      //Arrange
      string orderTitle = "Test Order";
      Order newOrder = new Order(orderTitle, "Order Description", "01/01/2011", 1);

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
      Order newOrder = new Order("Order Title", orderDescription, "01/01/2011", 1);

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
      Order newOrder = new Order("Order Title", "Order Description", orderDate, 1);

      //Act
      string result = newOrder.orderDate;

      //Assert
      Assert.AreEqual(orderDate, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Int()
    {
      //Arrange
      int orderPrice = 100;
      Order newOrder = new Order("Order Title", "Order Description", "01/01/2011", orderPrice);

      //Act
      int result = newOrder.orderPrice;

      //Assert
      Assert.AreEqual(orderPrice, result);
    }

    [TestMethod]
    public void GetOrderList_ReturnsAllOrderTitlesInList_OrderList()
    {
      //Arrange
      string orderTitleOne = "Test Order";
      string orderTitleTwo = "Test Order 2";
      Order newOrderOne = new Order(orderTitleOne, "Order Description", "01/01/2011", 1);
      Order newOrderTwo = new Order(orderTitleTwo, "Order Description", "01/02/2011", 2);
      List<Order> newOrderList = new List<Order> { newOrderOne, newOrderTwo };

      //Act
      List<Order> result = Order.GetOrderList();

      //Assert
      CollectionAssert.AreEqual(newOrderList, result);
    }
    
    [TestMethod]
    public void GetOrderId_ReturnsOrderId_Int()
    {
      //Arrange
      string orderTitle = "Homer's Dohnuts";
      Order newOrder = new Order(orderTitle, "Order Description", "01/01/2011", 1);

      //Act
      int result = newOrder.orderId;

      //Assert
      Assert.AreEqual(1, result);
    }    

  }  
}