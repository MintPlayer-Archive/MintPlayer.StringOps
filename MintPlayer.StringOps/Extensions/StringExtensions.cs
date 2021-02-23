namespace MintPlayer.StringOps.Extensions
{
    public static class StringExtensions
    {
        /// <summary>Makes the first character of a string upper-case.</summary>
        /// <param name="str">Input string</param>
        /// <returns>String with an upper-case first character.</returns>
        public static string UcFirst(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            char[] a = str.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}
