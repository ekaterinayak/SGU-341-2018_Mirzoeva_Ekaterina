using System;
using System.Collections.Generic;

namespace DOT_NET.Pyramid
{
    class Pyramid
    {
        public Pyramid(List<Point> points)
        {
            Points = points;
        }

        public Pyramid() { }

        private List<Point> Points { get; }

        //ищем высоту по теореме пифагора
        public double GetHeight()
        {
            double firstCathetus = Points[0].GetDistance(Points[2]) / 2;
            double hypotenuse = Points[0].GetDistance(Points[4]);

            return Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(firstCathetus, 2));
        }

        public double GetVolumeOfPyramid()
        {
            return GetVolumeOfArea() * GetHeight() / 3;
        }

        public double GetVolumeOfArea()
        {
            return Points[0].GetDistance(Points[1]) * Points[1].GetDistance(Points[2]);
        }

        override public string ToString()
        {
            string result = "Pyramid: \n";

            foreach (Point point in Points)
            {
                result += point.ToString() + "\n";
            }

            return result;
        }

        // есть равные точки
        private bool IsSamePointsEquals()
        {
            foreach(Point pointOne in Points)
            {
                foreach(Point pointTwo in Points)
                {
                    if (pointOne != pointTwo && pointTwo.GetDistance(pointOne) == 0.0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // в основании лежит прямоугольник
        private bool IsRectangleArea() => 
            Points[0].GetDistance(Points[1]) == Points[2].GetDistance(Points[3]) 
            && Points[1].GetDistance(Points[2]) == Points[0].GetDistance(Points[3]);

        // боковые ребра равны 
        private bool IsEquidistanceEdges() => Points[4].GetDistance(Points[1]) == Points[4].GetDistance(Points[0])
                && Points[4].GetDistance(Points[2]) == Points[4].GetDistance(Points[3])
                && Points[4].GetDistance(Points[1]) == Points[4].GetDistance(Points[3]);


        public void CheckValid()
        {
            bool isValid = IsValidPyramid();

            if (!isValid) throw new NotValidPyramidExeption("Pyramid is not valid");

            Console.WriteLine("Pyramid is valid");
        }

        private bool IsValidPyramid() => !IsSamePointsEquals() && IsRectangleArea() && IsEquidistanceEdges();
    }
}
