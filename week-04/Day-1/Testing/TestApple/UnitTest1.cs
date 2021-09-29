using Apples;
using System;
using Xunit;

namespace TestApple
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arange
            var apple1 = new Apple();
            string expected = "apple";

            //act
            string acutal = apple1.GetApple();

            //assert
            Assert.Equal(expected, acutal);



        }
    }
}
