using System.Collections.Generic;

namespace BakeryStore.Models
{
    public class Order 
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public int Price { get; set; }
    public string Date { get; set; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string name, string description, int price, string date)
    {
      Name = name;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAllOrders()
    {
      return _instances;
    }

    public static Order Find(int id)  
    {
      return _instances[id - 1];
    }

    public static void ClearOrders()
    {
      _instances.Clear();
    }
  }
}
