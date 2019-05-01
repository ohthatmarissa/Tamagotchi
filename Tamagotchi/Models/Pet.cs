using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    private string _name;
    private static List<Pet> _instances = new List<Pet> {};

    public Pet (string name)
    {
      _name = name;
      _instances.Add(this);
    }

    public static List<Pet> GetAll()
    {
      return _instances;
    }
  }
}
