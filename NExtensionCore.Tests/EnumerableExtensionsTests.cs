﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
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
