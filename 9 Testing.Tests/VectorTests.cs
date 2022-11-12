using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Testing.Tests
{
    public class VectorTests
    {
        [Fact]
        public void Add()
        {
            //arrange
            Vector v1 = new Vector(1, 0);
            Vector v2 = new Vector(2, 1);
            double expectedX = 3;
            double expectedY = 1;

            //act
            v1.Add(v2);
            double actualX = v1.X;
            double actualY = v1.Y;

            //assert
            Assert.Equal(actualX, expectedX);
            Assert.Equal(actualY, expectedY);
        }
    }
}
