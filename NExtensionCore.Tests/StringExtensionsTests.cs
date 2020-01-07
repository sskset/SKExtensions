using System;
using Xunit;
using NExtensions;

namespace NExtensionCore.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void Given_Null_WhenCall_IsNullOrEmpty_ShouldReturn_True()
        {
            string str = null;
<<<<<<< develop:xExtensions.Tests/StringExtensionsTests.cs

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
=======
            Assert.True(str.IsNullOrEmpty());
        }

        [Fact]
        public void Given_Empty_WhenCall_IsNullOrEmpty_ShouldReturn_True()
        {
            Assert.True(string.Empty.IsNullOrEmpty());
>>>>>>> rename projects:NExtensionCore.Tests/StringExtensionsTests.cs
        }
    }
}
