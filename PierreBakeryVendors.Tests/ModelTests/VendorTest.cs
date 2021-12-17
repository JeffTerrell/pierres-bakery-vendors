using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakeryVendors.Models;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTests
  {

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
  }
}    