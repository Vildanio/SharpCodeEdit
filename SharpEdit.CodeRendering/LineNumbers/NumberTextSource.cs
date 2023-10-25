using Avalonia.Media.TextFormatting;
using SharpEdit.Utils;

namespace SharpEdit.CodeRendering
{
    internal sealed class NumberTextSource : ITextSource
    {
        public IntRange Numbers { get; init; }

        public TextRun? GetTextRun(int textSourceIndex)
        {
            if (textSourceIndex < 0 || textSourceIndex >= Numbers.Count)
                throw new ArgumentOutOfRangeException(nameof(textSourceIndex));

            throw new NotImplementedException();
        }

        public NumberTextSource(IntRange numbers)
        {
            Numbers = numbers;
        }
    }
}
