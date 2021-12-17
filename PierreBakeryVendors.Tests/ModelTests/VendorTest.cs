using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreBakeryVendors.Models;
using System;

namespace PierreBakeryVendors.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

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

    [TestMethod]
    public void GetVendorList_ReturnsAllVendorObjectsInList_VendorList()
    {
      //Arrange
      string vendorNameOne = "Homer's Dohnuts";
      string vendorDescriptionOne = "Simpsons themed donut shop, also sells coffee";
      string vendorNameTwo = "Java's Ark Coffee House";
      string vendorDescriptionTwo = "Large coffee shop with multiple locations, also sells muffins and pastries";
      Vendor newVendor1 = new Vendor(vendorNameOne, vendorDescriptionOne);
      Vendor newVendor2 = new Vendor(vendorNameTwo, vendorDescriptionTwo);
      List<Vendor> newVendorList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetVendorList();

      //Assert
      CollectionAssert.AreEqual(newVendorList, result);
    }

    [TestMethod]
    public void GetVendorList_ReturnsAllVendorNamesInList_VendorList()
    {
      //Arrange
      string vendorNameOne = "Homer's Dohnuts";
      string vendorDescriptionOne = "Simpsons themed donut shop, also sells coffee";
      string vendorNameTwo = "Java's Ark Coffee House";
      string vendorDescriptionTwo = "Large coffee shop with multiple locations, also sells muffins and pastries";
      Vendor newVendor1 = new Vendor(vendorNameOne, vendorDescriptionOne);
      Vendor newVendor2 = new Vendor(vendorNameTwo, vendorDescriptionTwo);
      List<Vendor> newVendorList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetVendorList();

      //Assert
      CollectionAssert.AreEqual(newVendorList, result);
    }

    [TestMethod]
    public void GetVendorId_ReturnsVendorId_Int()
    {
      //Arrange
      string vendorName = "Homer's Dohnuts";
      string vendorDescription = "Simpsons themed donut shop, also sells coffee";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      //Act
      int result = newVendor.vendorId;

      //Assert
      Assert.AreEqual(1, result);
    }
  }
}    