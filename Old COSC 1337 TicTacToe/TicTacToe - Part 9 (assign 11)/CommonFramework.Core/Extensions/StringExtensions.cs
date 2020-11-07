namespace CommonFramework.Core
{
    /// <summary>
    ///     Various extension methods for string manipulation.
    /// </summary>
    /// <remarks>
    ///     These extensions were written by Mark Reynolds and are made available for instructional purposes
    ///     Copyright 2011-2018 by Mark Reynolds.
    /// </remarks>
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string content)
        {
            return string.IsNullOrEmpty(content);
        }


        public static string Left(this string content, int numCharacters)
        {
            if (string.IsNullOrEmpty(content)) return string.Empty;
            if (numCharacters < 0) return string.Empty;
            return content.Length < numCharacters
                ? content
                : content.Substring(0, numCharacters);
        }


        public static string Right(this string content, int numCharacters)
        {
            if (string.IsNullOrEmpty(content)) return string.Empty;
            if (numCharacters < 0) return string.Empty;
            return content.Length < numCharacters
                ? content
                : content.Substring(content.Length - numCharacters, numCharacters);
        }
    }
}