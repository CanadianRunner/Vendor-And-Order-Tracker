using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests

{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearVendors();
    }

    [TestMethod]
    public void VendorConstructor_InstantiateVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Luke Skywalker", "Moisture farmer on Tatooine"); 
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      Vendor newVendor = new Vendor("Luke Skywalker", "Moisture farmer on Tatooine"); 
      Assert.AreEqual("Luke Skywalker", newVendor.Name);
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      Vendor newVendor = new Vendor("Luke Skywalker", "Moisture farmer on Tatooine"); 
      Assert.AreEqual("Moisture farmer on Tatooine", newVendor.Description);
    }
  }
}