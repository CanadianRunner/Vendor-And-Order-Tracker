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

[TestMethod]
public void GetName_ReturnName_String()
{
  Order newOrder = new Order("Daffy Duck", "15 pastries", 83, "2022-07-15");
  Assert.AreEqual("Daffy Duck",newOrder.Name);
}

[TestMethod]
public void GetDescription_ReturnDescription_String()
{
  Order newOrder = new Order("Daffy Duck", "15 pastries", 83, "2022-07-15");
  Assert.AreEqual("15 pastries",newOrder.Description);
}

[TestMethod]
public void GetPrice_ReturnPrice_Int()
{
  Order newOrder = new Order("Daffy Duck", "15 pastries", 83, "2022-07-15");
  Assert.AreEqual(83,newOrder.Price);
}

[TestMethod]
public void GetDate_ReturnDate_String()
{
  Order newOrder = new Order("Daffy Duck", "15 pastries", 83, "2022-07-15");
  Assert.AreEqual("2022-07-15",newOrder.Date);
}

[TestMethod]
public void GetId_ReturnId_Int()
{
  Order newOrder = new Order("Daffy Duck", "15 pastries", 83, "2022-07-15");
  Assert.AreEqual(1,newOrder.Id);
}

[TestMethod]
public void GetAllOrders_ReturnsAllOrders_OrderList()
{
  Order newOrder = new Order("Daffy Duck", "15 pastries", 83, "2022-07-15");
  Order secondOrder = new Order("Cthulhu", "150 pastries", 400, "2023-04-10");
  List<Order> allOrders = new List<Order> {newOrder, secondOrder};
  CollectionAssert.AreEqual(allOrders, Order.GetAllOrders());
}

[TestMethod]
public void Find_ReturnsCorrectOrderIndex_OrderId()
{
  Order newOrder = new Order("Daffy Duck", "15 pastries", 83, "2022-07-15");
  Order secondOrder = new Order("Cthulhu", "150 pastries", 400, "2023-04-10");
  List<Order> allOrders = new List<Order> {newOrder, secondOrder};
  Assert.AreEqual(secondOrder, Order.Find(2));
}
}
}