namespace GeometryLibrary.ShapeTests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void CircleArea_CorrectRadius_ReturnsArea()
        {
            var circle = new Circle(10);
            Assert.AreEqual(Math.PI * 100, circle.GetArea(), 1e-10);
        }

        [TestMethod]
        public void TriangleArea_ValidSides_ReturnsArea()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetArea(), 1e-10);
        }

        [TestMethod]
        public void Triangle_IsRightTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }
    }
}
