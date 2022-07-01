using System;

namespace Figure
{
    public class Circle : Figure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным!");
            }

            _radius = radius;
        }

        public override double Square()
        {
            return Math.PI * _radius * _radius;
        }
    }

    public class Triangle : Figure
    {
        private readonly double _firstSide;
        private readonly double _sedondSide;
        private readonly double _thirdSide;

        public Triangle(double firstSide, double sedondSide, double thirdSide)
        {
            if (firstSide < 0 || sedondSide < 0 || thirdSide < 0)
            {
                throw new ArgumentException("Стороны не могут быть отрицательными");
            }
            _firstSide = firstSide;
            _sedondSide = sedondSide;
            _thirdSide = thirdSide;
        }

        public override double Square()
        {
            double semiPerimeter = (_firstSide + _sedondSide + _thirdSide) / 2;
            double valueA = semiPerimeter - _firstSide;
            double valueB = semiPerimeter - _sedondSide;
            double valueC = semiPerimeter - _firstSide;

            return Math.Sqrt(semiPerimeter * valueA * valueB * valueC);
        }
    }
}
