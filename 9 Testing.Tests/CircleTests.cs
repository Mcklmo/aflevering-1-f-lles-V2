
using _9_Testing;
using Xunit;
namespace _9_Testing.Tests
{
    public class CircleTests
    {
        [Fact]
        public void PointIsInFalse()
        {
            // arrange
            Circle c = new Circle(0,0,1);

            //act
            bool output = c.PointIsIn(c.center_x+1, c.center_y+1);

            //assert
            Assert.False(output);
        }
        [Fact]
        public void PointIsInTrue()
        {
            // arrange
            Circle c = new Circle(0,0,1);

            //act
            bool output = c.PointIsIn(c.center_x,c.center_y);

            //assert
            Assert.True(output);
        }
        [Fact]
        public void CircleOverlapsTrue()
        {
            // arrange
            Circle c1 = new Circle(0,0,1);
            Circle c2 = new Circle(1, 0, 1);

            // act
            bool output = c1.CircleOverlaps(c2);

            // assert
            Assert.True(output);
        }
        [Fact]
        public void CircleOverlapsFalse()
        {
            // arrange
            Circle c1 = new Circle(0, 0, 1);
            Circle c2 = new Circle(2, 0, 1);

            // act
            bool output = c1.CircleOverlaps(c2);

            // assert
            Assert.False(output);
        }
    }
}