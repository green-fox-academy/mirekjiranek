using Apples;
using System;
using System.Collections.Generic;
using Xunit;

namespace SumTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arange
            var apple2 = new Apple();
            int expected = 6;

            //act
            int acutal = apple2.Sum(new int[] {1,2,3});

            //assert
            Assert.Equal(expected, acutal);

        }
        [Theory]
        [InlineData(0, null)]
        [InlineData(0, new int[] { })]
        [InlineData(1, new int[] {1})]
        [InlineData(3, new int[] {1,2})]
        public void DifferentTests(int expected, int[] input)
        {
            //Act
            var apple3 = new Apple();
            int actual = apple3.Sum(input);

            //assert
            Assert.Equal(expected, actual);
        }


    }
}
