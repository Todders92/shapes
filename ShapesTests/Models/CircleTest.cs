using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests
  {
    [TestMethod]
    public void Circle_GetAreaOfCircle()
    {
      // Arrange 
      Circle newCircle = new Circle(4);
      // Act
      double result = newCircle.GetArea();
      Assert.AreEqual(result, 50.24);
    }
  }
}