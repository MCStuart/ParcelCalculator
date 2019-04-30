using System;
using System.Collections.Generic;

namespace ParcelShop {

  public class Parcel
  {

    private int _length;
    private int _depth;
    private int _height;
    private int _weight;

    static List<Parcel> myParcelList = new List<Parcel>();

    public int length { get => _length; set => _length = value; }
    public int depth { get => _depth; set => _depth = value; }
    public int height { get => _height; set => _height = value; }
    public int weight { get => _weight; set => _weight = value; }

    public Parcel(int length, int depth, int height, int weight)
    {
      _length = length;
      _depth = depth;
      _height = height;
      _weight = weight;
      myParcelList.Add(this);
    }

    public int Volume()
    {
      int volume = length * depth * height;
      return volume;
    }

    public int CostToShip()
    {
      int cost = Volume() * weight * 2;
      return cost;
    }

    public static List<Parcel> GetAll()
    {
      return myParcelList;
    }


  }
}
