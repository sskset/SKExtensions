using System.Collections;
using Xunit;
using NExtensions;

namespace NExtensionCore.Tests
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
