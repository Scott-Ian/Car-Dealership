using System;

namespace Dealership.Models 
{
  public class Car
  {
    private string _makeModel;
    public string makeModel
    {
      get
      {
        return _makeModel;
      }
      set
      {
        _makeModel = value;
      }
    }

    public string MakeModel {get; set;}
    private int _price;
    private int _miles;
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
  
    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetMakeModel(string makemodel)
    {
      _makeModel = makeModel;
    }
    public int GetPrice()
    {
      return _price;
    }
    public int GetMiles()
    {
      return _miles;
    }
    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }

    public static string MakeSound (string sound)
    {
      return "Our cars sound like " + sound;
    }
  }
}