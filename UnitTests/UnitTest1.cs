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
            Assert.Equal("������� ������������: " + 10, result);
          }
        [Fact]
        public void TriengleResultrectangularTrue()
        {
            ReturnFromUserView returnfigure = new ReturnFromUserView();
            string result = returnfigure.ReturnTreangle(10, 10, 10);
            Assert.Equal("������� �������������� ������������: 50", result);
        }
        [Fact]
        public void TriengleResultIsNullTrue()
        {
            ReturnFromUserView returnfigure = new ReturnFromUserView();
            string result = returnfigure.ReturnTreangle(0, 0, 0);
            Assert.Equal("��� �� �����������", result);
        }
        [Fact]
        public void CircleResult()
        {
            ReturnFromUserView returnfigure = new ReturnFromUserView();
            string result = returnfigure.ReturnCircle(90);
            Assert.Equal("������� �����: 25447", result);
        }
    }
}