using System.Collections.Generic;

namespace PierresOrderApp.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public static List<Order> orders = new List<Order> { };//probably not

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      //List <Order> = orders;//nope
      //orders.AddOrder(orders);//probably not either
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}