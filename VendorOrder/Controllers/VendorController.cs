using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAllVendors();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> vendorDict = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorsOrders = selectedVendor.OrdersList;
      vendorDict.Add("orders", vendorsOrders);
      vendorDict.Add("vendors", selectedVendor);
      return View(vendorDict);
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(string name, string description, int price, string date, int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      Order newOrder = new Order(name, description, price, date);
      selectedVendor.AddOrder(newOrder);
      List<Order> vendorsOrders = selectedVendor.OrdersList;
      model.Add("orders", vendorsOrders);
      model.Add("vendors", selectedVendor);
      return View("Show", model);
    }
  }
}

