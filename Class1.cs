namespace StringExtensions
{
    public static class StringExtensions
    {
        public static bool StartsWithUpper(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            return char.IsUpper(value[0]);
        }
    }
}
