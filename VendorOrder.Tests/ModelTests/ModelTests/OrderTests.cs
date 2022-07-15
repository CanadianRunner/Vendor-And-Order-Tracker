using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests

{
   [TestClass]
   public class ItemTests : IDisposable
   {
    public void Dispose()
    {
      Order.ClearOrders();
    }

[TestMethod]
public void OrderConstructor_BuildsOrder_Order()
{
  Order newOrder = new Order("Daffy Duck", "15 pastries", 83, "2022-07-15");
  Assert.AreEqual(typeof(Order), newOrder.GetType());
}
}
}