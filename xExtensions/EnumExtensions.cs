using System;
using System.Collections.Generic;
using System.Text;

namespace xExtensions
{
    public static class EnumExtensions
    {
        public static string DisplayName(this Enum source)
        {
            return Enum.GetName(source.GetType(), source);
        }
    }
}
