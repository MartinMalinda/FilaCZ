using System;
using System.Collections.Generic;
using Xunit;
using SumTest;




namespace XUnitSumTestProject
{
    public class UnitTest1
    {
       


        [Fact]
        public void Test1()
        {
            var numbers = new List<int> { 1, 2, 3 };
            Assert.Equal(6, Program.Sum(numbers));
        }

        [Fact]
        public void Test2()
        {
            var numbers = new List<int> {5};
            Assert.Equal(5, Program.Sum(numbers));
        }

        [Theory]
        [InlineData(8, 1, 7, 8, 24)]
        [InlineData(7, 1, 7, 8, 23)]
        [InlineData(8, 1, 0, 8, 5)]
        public void Test3(int a, int b, int c, int d, int expected)
        {
        List<int> numbers = new List<int> { a, b, c, d };
        Assert.Equal(expected, Program.Sum(numbers));
        }

        [Theory]
        [InlineData(null)]
        [InlineData(0)]
        public void Test4(int a)
        {
            List<int> numbers = new List<int> { a };
            Assert.Equal(0, Program.Sum(numbers));
        }

        [Fact]
        public void Test5()
        {
            List<int> listNull = null;
            Assert.Throws<NullReferenceException>(() => Program.Sum(listNull));
        }
    }
}
