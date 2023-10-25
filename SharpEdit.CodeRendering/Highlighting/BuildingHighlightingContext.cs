using Avalonia.Media;

namespace SharpEdit.CodeRendering.Highlighting
{
    internal class BuildingHighlightingContext : IHighlightingContext
    {
        public void Highlight(Brush brush, int start, int count)
        {
            throw new NotImplementedException();
        }

        public IVisualTextDocument BuildDocument()
        {
            throw new NotImplementedException();
        }
    }
}
