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
    public static class BooleanExtensions
    {
        public static bool ToBool(this object content, bool defaultValue)
        {
            try
            {
                bool boolResult;

                var conversionSuccessful = (bool.TryParse(content.ToString(), out boolResult));

                return conversionSuccessful ? boolResult : defaultValue;
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                return defaultValue;
            }
        }
    }
}

