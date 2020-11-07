using System;
using System.Diagnostics;
using System.Globalization;

namespace CommonFramework.Core
{
    /// <summary>
    ///     Various extension methods for numeric manipulation.
    /// </summary>
    /// <remarks>
    ///     These extensions were written by Mark Reynolds and are made available for instructional purposes
    ///     Copyright 2011-2018 by Mark Reynolds.
    /// </remarks>
    public static class NumericExtensions
    {
        /// <summary>
        ///     Converts an object into a standard int, if possible
        /// </summary>
        /// <author>Mark Reynolds</author>
        /// <param name="content">extended object variable</param>
        /// <param name="defaultValue">vaule to return if not convertable</param>
        /// <returns>resulting value - either the converted value or the default</returns>
        public static int ToInt32(this object content, int defaultValue)
        {
            try
            {
                if (content == null) return defaultValue;
                if (content.Equals(DBNull.Value)) return defaultValue;

                return int.TryParse(content.ToString(), out var result) ? result : defaultValue;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return defaultValue;
            }
        }

        /// <summary>
        ///     Performs a basic ToString operation on a Int32? - but returns an empty string if null
        /// </summary>
        /// <author>Mark Reynolds</author>
        /// <param name="content">extended Int32? variable</param>
        /// <returns>ToString result</returns>
        public static string ToString(this int? content)
        {
            return content?.ToString(CultureInfo.InvariantCulture) ?? string.Empty;
        }
    }
}