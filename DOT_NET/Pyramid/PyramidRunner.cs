using System;

namespace DOT_NET.Pyramid
{
    class PyramidRunner
    {
        public static void run()
        {
            Pyramid pyramid = PyramidReader.readPyramidFromFile("points.txt");

            Console.WriteLine(pyramid.ToString());

            Console.WriteLine($"Volume of pyramid {pyramid.GetVolumeOfPyramid()}");
            Console.WriteLine($"Volume of area {pyramid.GetVolumeOfArea()}");
        }
    }
}
