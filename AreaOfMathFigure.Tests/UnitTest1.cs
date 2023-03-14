namespace AreaOfMathFigure.Tests
{
    public class AreaOfMathFigureTests
    {
        [Fact]
        public void RightTriangleTest()
        {
            Assert.True(AreaOfMathFigure.CheckTriangle(4, 5, 3));
        }
        [Fact]
        public void AreaCheck()
        {
            Assert.Equal(Math.PI * Math.Pow(7, 2), AreaOfMathFigure.Area(7));
            double p = (double)(7 + 4 + 6) / (double)2;
            double res = Math.Sqrt(p * (p - 7) * (p - 4) * (p - 6));
            Assert.Equal(res, AreaOfMathFigure.Area(7, 4, 6));
            Assert.Equal(9 * 4, AreaOfMathFigure.Area(9, 4));
        }
    }
}