using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    private string _name;
    private int _id;
    private static List<Pet> _instances = new List<Pet> {};

    public Pet (string name)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public static List<Pet> GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }
    public string GetName()
    {
      return _name;
    }
    public static Pet Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
