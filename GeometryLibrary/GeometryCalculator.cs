using System;

namespace GeometryLibrary
{
    public class GeometryCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculateTriangleArea(double x, double y, double z)
        {
            double s = (x + y + z) / 2;
            return Math.Sqrt(s * (s - x) * (s - y) * (s - z));
        }

        public static bool IsRightTriangle(double x, double y, double z)
        {
            double[] sides = { x, y, z };
            Array.Sort(sides);

            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }
    }
}