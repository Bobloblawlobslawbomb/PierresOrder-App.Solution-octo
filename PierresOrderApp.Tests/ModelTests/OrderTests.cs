using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderApp.Models;
using System.Collections.Generic;
using System;

namespace PierresOrderApp.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("sampleOrder", "sampleDescription", 1, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string name01 = "Pac Coast";
      string desc01 = "Fruit";
      int price01 = 10;
      string date01 = "Today";
      Order newOrder1 = new Order(name01, desc01, price01, date01);
      string result = newOrder1.Title;
      Assert.AreEqual(name01, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name01 = "Pac Coast";
      string desc01 = "Fruit";
      int price01 = 10;
      string date01 = "Today";
      Order newOrder1 = new Order(name01, desc01, price01, date01);
      string result = newOrder1.Description;
      Assert.AreEqual(desc01, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      string name01 = "Pac Coast";
      string desc01 = "Fruit";
      int price01 = 10;
      string date01 = "Today";
      Order newOrder1 = new Order(name01, desc01, price01, date01);
      int result = newOrder1.Price;
      Assert.AreEqual(price01, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string name01 = "Pac Coast";
      string desc01 = "Fruit";
      int price01 = 10;
      string date01 = "Today";
      Order newOrder1 = new Order(name01, desc01, price01, date01);
      string result = newOrder1.Date;
      Assert.AreEqual(date01, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string name01 = "Pac Coast";
      string name02 = "Charlie's Produce";
      string desc01 = "Fruit";
      string desc02 = "Vegetable";
      int price01 = 10;
      int price02 = 20;
      string date01 = "Today";
      string date02 = "Yesterday";
      Order newOrder1 = new Order(name01, desc01, price01, date01);
      Order newOrder2 = new Order(name02, desc02, price02, date02);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

  }
}