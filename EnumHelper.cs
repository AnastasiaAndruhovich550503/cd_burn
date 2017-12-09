using System;
using System.ComponentModel;
using System.Reflection;

namespace CDBurn
{
    public static class EnumHelper
    {
        public static string ToReadableString(this Enum @enum)
        {
            if (@enum == null) return null;
            var description = @enum.ToString();
            try
            {
                FieldInfo fi = @enum.GetType().GetField(@enum.ToString());
                DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes.Length > 0)
                    description = attributes[0].Description;
            }
            catch
            {
                // ignored
            }
            return description;
        }
    }
}