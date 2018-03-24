using System;
using System.Collections.Generic;
using System.IO;

namespace DOT_NET.Pyramid
{
    class PyramidReader
    {
        private const int countOfPoints = 5;
        private const int countOfCoordinates = 3;

        public PyramidReader() { }

        public static Pyramid readPyramidFromFile(string pathToFile)
        {
            if (!File.Exists(pathToFile))
            {
                throw new FileNotFoundException("File not exists");
            }

            List<Point> points = new List<Point>();

            using (StreamReader streamReader = new StreamReader(pathToFile))
            {
                string lineFromFile = streamReader.ReadLine();

                while (lineFromFile != null && points.Count != countOfPoints)
                {
                    string[] coordinates = lineFromFile.Split(' ');

                    if (coordinates.Length != countOfCoordinates)
                    {
                        throw new PointsCountPyramidException($"Count coordinates in file ({coordinates.Length}) not equals required({countOfCoordinates})");
                    }

                    double x, y, z;
                    try
                    {
                        x = double.Parse(coordinates[0]);
                        y = double.Parse(coordinates[1]);
                        z = double.Parse(coordinates[2]);
                    }
                    catch (FormatException ex)
                    {
                        throw new FormatException("Invalid data format");
                    }

                    points.Add(new Point(x, y, z));

                    lineFromFile = streamReader.ReadLine();
                }
            }

            if (points.Count != countOfPoints)
            {
                throw new PointsCountPyramidException($"Count points in file ({points.Count}) not equals required({countOfPoints})");
            }

            return new Pyramid(points);
        }
    }
}
