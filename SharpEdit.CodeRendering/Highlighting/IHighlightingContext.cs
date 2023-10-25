using Avalonia.Media;

namespace SharpEdit.CodeRendering.Highlighting
{
    public interface IHighlightingContext
    {
        public void Highlight(Brush brush, int start, int count);
    }
}
