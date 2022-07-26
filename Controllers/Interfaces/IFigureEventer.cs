using ShapesLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary.Controllers.Interfaces
{
    public interface IFigureEventer
    {
        string ReturnСircleArea(CircleModel circle);
        string ReturnTriangleArea(TriengleModel triengle);
    }
}
