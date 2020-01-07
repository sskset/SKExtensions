using System.Collections;
using Xunit;
using SKExtensions.Core;

namespace NExtensions.Core.Tests
{
    public class EnumerableExtensionsTests
    {
        [Fact]
        public void Given_Null_WhenCall_IsNullOrEmpty_ShouldReturn_True()
        {
            IEnumerable enu = null;
            Assert.True(enu.IsNullOrEmpty());
        }
    }
}
