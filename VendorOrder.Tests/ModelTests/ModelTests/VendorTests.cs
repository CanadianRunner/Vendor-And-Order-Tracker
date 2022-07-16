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

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      Vendor newVendor = new Vendor("Luke Skywalker", "Moisture farmer on Tatooine"); 
      int vendorIndex = newVendor.Id;
      Assert.AreEqual(1, vendorIndex);
    }

    [TestMethod]
    public void GetAllVendors_ReturnsAllVendors_VendorList()
    {
    Vendor newVendor = new Vendor("Luke Skywalker", "Moisture farmer on Tatooine");
    Vendor secondVendor = new Vendor("Ankain Skywalker", "Youngling Trainer");
    List<Vendor> allVendors = new List<Vendor> {newVendor, secondVendor};
    CollectionAssert.AreEqual(allVendors, Vendor.GetAllVendors());
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrderIndex_Vendor()
    {
    Vendor newVendor = new Vendor("Luke Skywalker", "Moisture farmer on Tatooine");
    Vendor secondVendor = new Vendor("Ankain Skywalker", "Youngling Trainer");
    List<Vendor> allVendors = new List<Vendor> {newVendor, secondVendor};
    Assert.AreEqual(secondVendor, Vendor.Find(2));
    }

    [TestMethod]
    public void AddOrder_RegisterToOnlyOneVendor_Vendor()
    {
    Vendor newVendor = new Vendor("Luke Skywalker", "Moisture farmer on Tatooine");
    Vendor secondVendor = new Vendor("Ankain Skywalker", "Youngling Trainer");
    Order newOrder = new Order("Combo 3", "15 pastries", 83, "2022-07-15");
    List<Order> vendorOrders = new List<Order> {newOrder};
    newVendor.AddOrder(newOrder);
    CollectionAssert.AreEqual(vendorOrders, newVendor.OrdersList);
    }
}
}
