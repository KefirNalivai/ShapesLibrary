using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassShapesLibrary
{
    public class Trapezoid: IShape
    {
        public double a1 { get; set; }
        public double a2 { get; set; }
        public double h { get; set; }

        public Trapezoid(double _a1, double _a2, double _h)
        {
            this.a1 = _a1;
            this.a2 = _a2;
            this.h = _h;
        }

        public double CalcArea()
        {
            return ((a1 + a2) / 2) * h;
        }
    }
}
