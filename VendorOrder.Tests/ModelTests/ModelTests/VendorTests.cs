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
  }
}