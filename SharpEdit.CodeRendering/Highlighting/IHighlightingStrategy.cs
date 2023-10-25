using SharpEdit.Text;

namespace SharpEdit.CodeRendering.Highlighting
{
    public interface IHighlightingStrategy
    {
        public void Highlight(IHighlightingContext context, IReadOnlyText text)
        {
            Highlight(context, text, 0, text.Count);
        }

        public void Highlight(IHighlightingContext context, IReadOnlyText text, int start, int count);

        public void Highlight(IHighlightingContext context, ReadOnlyMemory<char> text)
        {
            Highlight(context, text, 0, text.Length);
        }

        public void Highlight(IHighlightingContext context, ReadOnlyMemory<char> text, int start, int count);
    }
}
