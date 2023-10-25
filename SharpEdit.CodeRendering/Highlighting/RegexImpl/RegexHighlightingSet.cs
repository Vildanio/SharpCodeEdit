namespace SharpEdit.CodeRendering.Highlighting.RegexImpl
{
    public class RegexHighlightingSet
    {
        public string? Name { get; }

        public IEnumerable<HighlightingPattern> HighlightingPatterns { get; }

        public RegexHighlightingSet(IEnumerable<HighlightingPattern> highlightingPatterns, string? name = null)
        {
            Name = name;
            HighlightingPatterns = highlightingPatterns;
        }
    }
}
