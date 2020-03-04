using System;

namespace Shapes.Models
{

  public class Circle
  {
    public int Radius { get; set; }
    public Circle(int radius)
    {
      Radius = radius;
    }
    public double GetArea()
    {
      return (Radius * Radius) * 3.14;
    }
  }
  
}