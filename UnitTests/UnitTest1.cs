using ShapesLibrary.Views;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TriengleResultTrue()
        {
            ReturnFromUserView returnfigure = new ReturnFromUserView();
            string result = returnfigure.ReturnTreangle(10, 2, 10);
            Assert.Equal("Площадь треугольника: " + 10, result);
          }
        [Fact]
        public void TriengleResultrectangularTrue()
        {
            ReturnFromUserView returnfigure = new ReturnFromUserView();
            string result = returnfigure.ReturnTreangle(10, 10, 10);
            Assert.Equal("Площадь прямоугольного треугольника: 50", result);
        }
        [Fact]
        public void TriengleResultIsNullTrue()
        {
            ReturnFromUserView returnfigure = new ReturnFromUserView();
            string result = returnfigure.ReturnTreangle(0, 0, 0);
            Assert.Equal("Это не треугольник", result);
        }
        [Fact]
        public void CircleResult()
        {
            ReturnFromUserView returnfigure = new ReturnFromUserView();
            string result = returnfigure.ReturnCircle(90);
            Assert.Equal("Площадь круга: 25447", result);
        }
    }
}