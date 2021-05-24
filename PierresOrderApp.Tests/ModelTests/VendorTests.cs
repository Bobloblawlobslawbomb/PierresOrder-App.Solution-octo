using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderApp.Models;
using System.Collections.Generic;
using System;

namespace PierresOrderApp.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("sampleVendor", "sampleDescription");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Pac Coast";
      string desc = "Fruit";
      Vendor newVendor = new Vendor(name, desc);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Pac Coast";
      string desc = "Fruit";
      Vendor newVendor = new Vendor(name, desc);
      string result = newVendor.Description;
      Assert.AreEqual(desc, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Pac Coast";
      string desc = "Fruit";
      Vendor newVendor = new Vendor(name, desc);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsListOfAllVendorObjects_List()
    {
      string name01 = "Pac Coast";
      string name02 = "Charlie's Produce";
      string desc01 = "Fruit";
      string desc02 = "Vegetable";

      Vendor newVendor1 = new Vendor(name01, desc01);
      Vendor newVendor2 = new Vendor(name02, desc02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Pac Coast";
      string name02 = "Charlie's Produce";
      string desc01 = "Fruit";
      string desc02 = "Vegetable";
      Vendor newVendor1 = new Vendor(name01, desc01);
      Vendor newVendor2 = new Vendor(name02, desc02);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_VendorList()
    {
      string newOrderTitle = "Buy Meat";
      string newOrderDescription = "Buy All the Meat";
      int newOrderPrice = 20;
      string newOrderDate = "Today";
      Order newOrder = new Order(newOrderTitle, newOrderDescription, newOrderPrice, newOrderDate);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Charlie's Produce";
      string desc = "Vegetable";
      Vendor newVendor = new Vendor(name, desc);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}