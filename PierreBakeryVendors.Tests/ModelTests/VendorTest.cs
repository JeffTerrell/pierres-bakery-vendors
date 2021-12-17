using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakeryVendors.Models;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTests
  {

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      //Arrange
      string vendorName = "Test Vendor";
      Vendor newVendor = new Vendor(vendorName, "description");

      //Act
      string result = newVendor.vendorName;

      //Assert
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnsVendorDescription_String()
    {
      //Arrange
      string vendorDesciption = "Coffee shop that also sells muffins and pastries";
      Vendor newVendor = new Vendor("Test Vendor", vendorDesciption);

      //Act
      string result = newVendor.vendorDescription;

      //Assert
      Assert.AreEqual(vendorDesciption, result);
    }
  }
}    