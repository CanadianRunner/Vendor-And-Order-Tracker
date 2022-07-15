using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor 
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> OrdersList {get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      OrdersList = new List<Order> {};
    }

    public static List<Vendor> GetAllVendors()
    {
      return _instances;
    }

    public static Vendor Find(int id)  
    {
      return _instances[id - 1];
    }

    public void AddOrder(Order vendorOrder)
    {
      OrdersList.Add(vendorOrder);
    }

    public static void ClearVendors()
    {
      _instances.Clear();
    }
  }
}