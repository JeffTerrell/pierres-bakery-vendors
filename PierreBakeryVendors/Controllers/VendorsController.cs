using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierreBakeryVendors.Models;

namespace PierreBakeryVendors.Controllers
{
  public class VendorsController : Controller
  {
  
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetVendorList();
      return View(allVendors);
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    } 

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendors", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
  }
}