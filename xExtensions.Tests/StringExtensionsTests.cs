using System;
using Xunit;

namespace xExtensions.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void Given_Null_WhenCall_IsNullOrEmpty_ShouldReturn_True()
        {
            string str = null;

            Assert.True(str.IsNullOrEmpty());
        }

        [Fact]
        public void Given_Empty_WhenCall_IsNullOrEmpty_ShouldReturn_True()
        {
            string str = "";
            Assert.True(str.IsNullOrEmpty());
        }

        [Fact]
        public void Given_AllWhteSpaces_WhenCall_IsNullOrEmpty_ShouldReturn_True()
        {
            string str = "     ";
            Assert.True(str.IsNullOrEmpty());
        }
    }
}
