using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int id)
    {
      Vendor newVendor = Vendor.Find(id);
      return View(newVendor);
    }

    [HttpGet("vendors/{id}/orders/{orderId}")]
    public ActionResult Show(int id, int orderId)
    {
      Order selectedOrder = Order.Find(orderId);
      Vendor selectedVendor = Vendor.Find(id);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("orders", selectedOrder);
      model.Add("vendors", selectedVendor);
      return View(model);
    }
  }
}
