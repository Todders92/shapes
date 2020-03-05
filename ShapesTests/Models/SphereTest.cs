using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {
    [TestMethod]
    public void Circle_GetVolumeOfCircle()
    {
      // Arrange 
      Circle newCircle = new Circle(4);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.GetVolume();
      Assert.AreEqual(result, 200.96);
    }
  }
}