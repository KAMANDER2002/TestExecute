using ShapesLibrary.Controllers;
using ShapesLibrary.Controllers.Interfaces;
using ShapesLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary.Views
{
    public class ReturnFromUserView
    {
        private readonly IFigureEventer _figureEventer = new FigureEventer();
        public ReturnFromUserView()
        {

        }

        public string ReturnCircle(double radius)
        {
            return _figureEventer.ReturnСircleArea(new CircleModel() { radius = radius });
        }
        public string ReturnTreangle(double first, double second, double trird)
        {
            return _figureEventer.ReturnTriangleArea(new TriengleModel() { firstSide = first, secondSide = second, thirdSide = trird });
        }
    }
}
