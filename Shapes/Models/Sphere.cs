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
      double radius3 = Math.Pow(ClassRadius.Radius, 3);
      double volume = (4/3) * 3.14 * radius3;
      return volume;
    }

    public double GetSurfaceArea()
    {
      double area = 4 * (3.14 * (Math.Pow(ClassRadius.Radius, 2)));
      return area;
    }

  }
}