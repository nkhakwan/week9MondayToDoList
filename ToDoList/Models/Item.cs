namespace ToDoList.Models
{
class Item
  {
    public string Description { get; set; }
    private static List<Item> _instances = new List<Item> {};

    public Item(string description)
    {
      Description = description;
      _instances.Add(this); // New code.
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }
    

  }
}