using ShapesLibrary.Controllers.Interfaces;
using ShapesLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary.Controllers
{
    internal class FigureEventer : CircleModel,IFigureEventer
    {
        public string ReturnTriangleArea(TriengleModel triengle)
        {
            if (triengle != null) //Определяем не ввел ли пользователь пустое значение 
            {
                if (triengle.firstSide >= triengle.secondSide + triengle.thirdSide || triengle.secondSide >= triengle.firstSide + triengle.thirdSide || triengle.thirdSide >= triengle.firstSide + triengle.secondSide) //Проверка на треугольник 
                {
                    return "Это не треугольник";
                }
                else
                {
                    double[] edges = { triengle.firstSide, triengle.secondSide, triengle.thirdSide };
                    Array.Sort(edges);

                    double a = edges[0] * edges[0];
                    double b = edges[2] * edges[2];
                    bool IsRight = a == b;
                    if (IsRight)
                    {
                        double S;
                        if (triengle.firstSide > triengle.secondSide && triengle.firstSide > triengle.thirdSide)
                        {
                            S = (triengle.secondSide * triengle.thirdSide) * 0.5;
                        }
                        else
                        if (triengle.secondSide > triengle.firstSide && triengle.secondSide > triengle.thirdSide)
                        {
                            S = (triengle.firstSide * triengle.thirdSide) * 0.5;
                        }
                        else S = (triengle.firstSide * triengle.thirdSide) * 0.5;
                        return "Площадь прямоугольного треугольника: " + Math.Round(S).ToString();
                    }
                    else
                    {
                        double R = (triengle.firstSide + triengle.secondSide + triengle.thirdSide) / 2;
                        return "Площадь треугольника: " + Math.Round((Math.Sqrt(R * (R - triengle.firstSide) * (R - triengle.secondSide) * (R - triengle.thirdSide)))).ToString();
                    }

                }
            }
            else return "Введите данные";
        }

        public string ReturnСircleArea(CircleModel circle) {
        if (circle.radius == 0){
                return "Это не круг";
        } else return "Площадь круга: " + Math.Round((Math.PI * Math.Pow(circle.radius, 2))).ToString(); 
        } //Вывод площади круга
    }
}
