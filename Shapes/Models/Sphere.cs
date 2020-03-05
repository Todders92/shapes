using System;

namespace Shapes.Models

{
  public class Sphere
  {
    public Circle ClassRadius { get; set; }
    public Sphere (Circle radius)
    {
      ClassRadius = radius;
    }

    public double GetVolume()
    {
      double radius2 = ClassRadius.Radius * ClassRadius.Radius * ClassRadius.Radius;
      double volume = (radius2 * 3.14) * (4/3);
      return volume;
    }

    // public double GetSurfaceArea()
    // {
    //   int area
    // }

  }
}