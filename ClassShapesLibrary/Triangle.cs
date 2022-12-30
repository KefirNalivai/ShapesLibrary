using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassShapesLibrary
{
    public class Triangle : IShape
    {
        public double a1 { get; set; }
        public double a2 { get; set; }
        public double a3 { get; set; }

        
        public Triangle(double _a1, double _a2, double _a3)
        {
            if (_a1 <= 0 || _a2 <= 0 || _a3 <= 0)
            {
                throw new ArgumentException("Числа не могут быть равны либо меньше нулю");
            }

            if (_a1 + _a2 < _a3 || _a2 + _a3 < _a1 || _a1 + _a3 < _a2)
            {
                throw new ArgumentException("Из данных сторон нельзя создать труегольник!");
            }

            this.a1 = _a1;
            this.a2 = _a2;
            this.a3 = _a3;


        }

        public double CalcArea()
        {
            double p = ((a1 + a2 + a3) / 2);
            return Math.Round(Math.Sqrt(p * (p - a1) * (p - a2) * (p - a3)), 2);
        }

        public bool isPryam()
        {
            double[] aa = new double[] { a1, a2, a3 };
            Array.Sort(aa);
            return Math.Pow(aa[0], 2) + Math.Pow(aa[1], 2) == Math.Pow(aa[2], 2);
        }
    }
}
