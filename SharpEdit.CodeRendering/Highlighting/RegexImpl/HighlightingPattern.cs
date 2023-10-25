using System.Text.RegularExpressions;
using Avalonia.Media;

namespace SharpEdit.CodeRendering.Highlighting.RegexImpl
{
    public record HighlightingPattern
    {
        public Regex Regex { get; init; }

        public Brush Brush { get; init; }

        public HighlightingPattern(Regex regex, Brush brush)
        {
            Regex = regex;
            Brush = brush;
        }
    }
}
