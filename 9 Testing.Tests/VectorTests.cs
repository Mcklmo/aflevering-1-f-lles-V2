using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Testing.Tests
{
    public class VectorTests
    {

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        public void AddXTheory(int value1, int value2, int expected)
        {
            //arrange
            Vector v1 = new Vector(value1, 0);
            Vector v2 = new Vector(value2, 0);

            //act
            v1.Add(v2);

            //assert
            Assert.Equal(expected, v1.X);
        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        public void AddYTheory(int value1, int value2, int expected)
        {
            //arrange
            Vector v1 = new Vector(0, value1);
            Vector v2 = new Vector(0, value2);

            //act
            v1.Add(v2);

            //assert
            Assert.Equal(expected, v1.Y);
        }
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(-4, -6, 2)]
        [InlineData(-2, 2, -4)]
        public void SubtractYTheory(int value1, int value2, int expected)
        {
            //arrange
            Vector v1 = new Vector(0, value1);
            Vector v2 = new Vector(0, value2);

            //act
            v1.Subtract(v2);

            //assert
            Assert.Equal(expected, v1.Y);
        }
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(-4, -6, 2)]
        [InlineData(-2, 2, -4)]
        public void SubtractXTheory(int value1, int value2, int expected)
        {
            //arrange
            Vector v1 = new Vector(0, value1);
            Vector v2 = new Vector(0, value2);

            //act
            v1.Subtract(v2);

            //assert
            Assert.Equal(expected, v1.X);
        }
        [Theory]
        [InlineData(1, 1, 2, 2)]
        [InlineData(-1, -1, 2, -2)]
        [InlineData(0, 0, 2, 0)]
        public void ScalarTheory(int vx, int vy, int scalar, int expected)
        {
            //arrange
            Vector v1 = new Vector(vx, vy);

            //act
            v1.Scalar(scalar);

            //assert
            Assert.Equal(expected, v1.X);
            Assert.Equal(expected, v1.Y);
        }
        [Theory]
        [InlineData(1, 1, 1, 1, 0)]
        [InlineData(1, 1, 2, 1, -1)]
        [InlineData(20,30,45,70,50)]
        public void CrossProductTheory(int v1x, int v1y, int v2x,int v2y, int expected)
        {
            //arrange
            Vector v1 = new Vector(v1x, v1y);
            Vector v2 = new Vector(v2x, v2y);

            //act
            double actual = v1.CrossProduct(v2);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
