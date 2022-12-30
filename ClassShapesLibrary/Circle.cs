using System;

namespace ClassShapesLibrary
{
    public class Circle: IShape
    {
        double r { get; set; }

        public Circle(double _r)
        {
            if (_r <= 0)
            {
                throw new ArgumentException("Радиус не может быть меньше или равен нулю");
            }

            this.r = _r;
        }

        public double CalcArea()
        {
            return Math.Round(Math.PI * Math.Pow(this.r, 2), 2);
        }
    }
}
