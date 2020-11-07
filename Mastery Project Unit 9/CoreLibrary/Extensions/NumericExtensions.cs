/*
 * ProfReynolds
 */

using System;
using System.Diagnostics;
using System.Net.Http;

namespace CoreLibrary
{
    /// <summary>
    /// Various extension methods for boolean manipulation.
    /// </summary>
    public static class NumericExtensions
    {
        /// <summary>
        ///     Safely converts an object into a standard int, or assigns a default value
        /// </summary>
        /// <author>Mark Reynolds</author>
        /// <param name="content">extended object variable</param>
        /// <param name="defaultValue">value to return if not convertible</param>
        /// <returns>either the converted value, or the default</returns>
        public static int ToInt(this object content, int defaultValue = 0)
        {
            try
            {
                //// try to perform a simple TryParse conversion
                //int intResult;
                //if (int.TryParse(content.ToString(), out intResult)) return intResult;

                //// or maybe the incoming value has a decimal value, try to convert to double
                //double dblResult;
                //if (double.TryParse(content.ToString(), out dblResult))
                //{
                //    var forceSuccessfulConversionToInteger = Convert.ToInt32(dblResult);
                //    return forceSuccessfulConversionToInteger;
                //}
                
                //return defaultValue;


                int intResult;
                if (int.TryParse(content.ToString(), out intResult)) return intResult;

                double dblResult;

                return (double.TryParse(content.ToString(), out dblResult))
                    ? Convert.ToInt32(dblResult)
                    : defaultValue;

            }
            catch
            {
                return defaultValue;
            }
        }
    }
}

