namespace SharpEdit.CodeEditing
{
    public static class Extensions
    {
        public static int GetIndent(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    return i;
                }
            }

            return 0;
        }

        public static int GetIndent(this ReadOnlySpan<char> span)
        {
            for (int i = 0; i < span.Length; i++)
            {
                if (span[i] != ' ')
                {
                    return i;
                }
            }

            return 0;
        }

        public static int GetIndent(this IReadOnlyList<char> buffer)
        {
            for (int i = 0; i < buffer.Count; i++)
            {
                if (buffer[i] != ' ')
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
