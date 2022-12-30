using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassShapesLibrary
{
    public class CalcWithoutIni
    {
        public double CalcCircleArea(double _r)
        {
            return new Circle(_r).CalcArea();
        }

        public double CalcTriangleArea(double _a1, double _a2, double _a3)
        {
            return new Triangle(_a1, _a2, _a3).CalcArea();
        }

        public double CalcTrapezoidArea(double _a1, double _a2, double _h)
        {
            return new Trapezoid(_a1, _a2, _h).CalcArea();
        }
    }
}
