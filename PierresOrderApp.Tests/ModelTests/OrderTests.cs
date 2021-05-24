using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderApp.Models;

namespace PierresOrderApp.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("sampleOrder", "sampleDescription", 1, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}