using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderApp.Models;

namespace PierresOrderApp.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("sampleVendor", "sampleDescription");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}