using SharpEdit.Text;

namespace SharpEdit.CodeRendering.Highlighting.RegexImpl
{
    public class RegexHighlightingStrategy : IHighlightingStrategy
    {
        public RegexHighlightingSet HighlightingSet { get; set; }

        public void Highlight(IHighlightingContext context, IReadOnlyText text, int start, int count)
        {
            ReadOnlySpan<char> span = text.AsString(start, count);

            foreach (var highlightPattern in HighlightingSet.HighlightingPatterns)
            {
                foreach (var match in highlightPattern.Regex.EnumerateMatches(span))
                {
                    context.Highlight(highlightPattern.Brush, match.Index, match.Length);
                }
            }
        }

        public RegexHighlightingStrategy(RegexHighlightingSet highlightingSet)
        {
            HighlightingSet = highlightingSet;
        }
    }
}
