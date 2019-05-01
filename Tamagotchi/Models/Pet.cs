using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    private string _name;
    private int _food;
    private int _happiness;
    private int _rest;
    private bool _alive;
    private int _id;
    private static List<Pet> _instances = new List<Pet> {};

    public Pet (string name)
    {
      _name = name;
      _food = 10;
      _happiness = 10;
      _rest = 10;
      _alive = true;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public static List<Pet> GetAll()
    {
      return _instances;
    }
    public static Pet Find(int searchId)
    {
      return _instances[searchId-1];
    }


    public int GetId()
    {
      return _id;
    }
    public int GetFood()
    {
      return _food;
    }
    public int GetHappiness()
    {
      return _happiness;
    }
    public int GetRest()
    {
      return _rest;
    }
    public string GetName()
    {
      return _name;
    }
  }
}
