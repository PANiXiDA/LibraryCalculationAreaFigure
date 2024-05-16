using GeometryLibrary;

namespace GeometryLibraryTests
{
    public class GeometryCalculatorTests
    {
        [Fact]
        public void CalculateCircleAreaTest()
        {
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;
            double actualArea = GeometryCalculator.CalculateCircleArea(radius);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void CalculateTriangleAreaTest()
        {
            double x = 3;
            double y = 4;
            double z = 5;
            double expectedArea = 6;
            double actualArea = GeometryCalculator.CalculateTriangleArea(x, y, z);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void IsRightTriangleTest()
        {
            double x = 3;
            double y = 4;
            double z = 5;
            bool isRightTriangle = GeometryCalculator.IsRightTriangle(x, y, z);
            Assert.True(isRightTriangle);
        }
    }
}