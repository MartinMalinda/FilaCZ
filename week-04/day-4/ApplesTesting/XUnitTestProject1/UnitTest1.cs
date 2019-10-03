using System;
using Xunit;
using Apples;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        

        [Fact]
        public void Test1()
        {
            var apple = new Apple();
            Assert.Equal("apple", apple.GetApple());
        }
    }
}
