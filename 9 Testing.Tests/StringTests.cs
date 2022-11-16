using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Testing.Tests
{
    public class StringTests
    {
        [Theory]
        [InlineData(new char[] { 'H', 'E', 'l', 'l', 'o' }, 1, 'E')]
        [InlineData(new char[] { 'H', 'E', 'l', 'l', 'o' }, 0, 'H')]
        [InlineData(new char[] { 'H', 'E', 'l', 'l', 'o' }, 4, 'o')]
        public void CharAtTrue(char[] s, int i, char expected)
        {
            //arrange
            String _s = new String(s);
            //act
            char actual = _s.CharAt(i);
            //assert
            Assert.True(actual == expected);
        }
        [Theory]
        [InlineData(new char[] { 'H', 'E', 'l', 'l', 'o' }, 5)]
        [InlineData(new char[] { 'H' }, 1)]
        [InlineData(new char[] {  }, 0)]
        public void LengthTrue(char[] s, int expected)
        {
            //arrange
            String _s = new String(s);
            //act
            int actual = _s.Length;
            //assert
            Assert.True(actual == expected);
        }
        [Theory]
        [InlineData(new char[] { 'H', 'E', 'l', 'l', 'o' }, new char[] { 'h', 'e', 'l', 'l', 'o' })]
        [InlineData(new char[] { 'H' }, new char[] { 'h' })]
        public void ToLowerCaseTrue(char[] input, char[] expected)
        {
            //arrange
            String _s = new String(input);
            //act
            char[] actual = _s.ToLowerCase();
            //assert
            Assert.Equal(expected,actual);
        }
        [Theory]
        [InlineData(new char[] { 'H', 'E', 'l', 'l', 'o' }, new char[] { 'h', 'e', 'l', 'l', 'o' }, false)]
        [InlineData(new char[] { 'H' }, new char[] { 'H' }, true)]
        public void EqualsTheory(char[] ca1, char[] ca2, bool expected)
        {
            //arrange
            String s1 = new String(ca1);
            String s2 = new String(ca2);
            //act
            bool actual = s1.Equals(s2);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
