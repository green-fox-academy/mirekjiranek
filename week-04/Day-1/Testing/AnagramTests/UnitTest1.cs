using System;
using Xunit;
using Anagrams;

namespace AnagramTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arange
            var anagram1 = new Anagram();
            bool expected = true;

            //act
            bool actual = anagram1.IsAnagram("shlip", "hipps");

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
