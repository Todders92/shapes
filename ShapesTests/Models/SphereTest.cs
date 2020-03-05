using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {
    [TestMethod]
    public void Circle_GetVolumeOfCircle_Double()
    {
      // Arrange 
      Circle newCircle = new Circle(4);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.GetVolume();
      Assert.AreEqual(result, 268.08);
    }
    // [TestMethod]

    // public void Sphere_GetSurfaceAreaOfSphere_Double()
    // {
    //   Circle newCircle = new Circle(4);
    //   Sphere newSphere = new Sphere(newCircle);

    //   double result = newSphere.GetSurfaceArea();
    //   Assert.AreEqual(result, 200.96);
    // }
  }
}