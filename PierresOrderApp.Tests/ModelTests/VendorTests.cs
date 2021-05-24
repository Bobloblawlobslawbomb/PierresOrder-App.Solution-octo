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
  }
}