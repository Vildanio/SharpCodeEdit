using SharpEdit.CodeRendering.Highlighting;
using SharpEdit.LineTextRendering;
using SharpEdit.VisualRendering;

namespace SharpEdit.CodeRendering
{
    public class HighlightedTextProvider : IVisualLineGroupProvider<IVisualTextDocument, IVisualText>
    {
        public IHighlightingStrategy HighlightingStrategy { get; }

        public virtual IVisualTextDocument GetVisual(IReadOnlyList<string> lines, int start, int count)
        {
            BuildingHighlightingContext context = new BuildingHighlightingContext();

            for (int i = start; i < start + count; i++)
            {
                ReadOnlyMemory<char> line = lines[i].AsMemory();

                HighlightingStrategy.Highlight(context, line);
            }

            return context.BuildDocument();
        }

        public HighlightedTextProvider(IHighlightingStrategy highlightingStrategy)
        {
            HighlightingStrategy = highlightingStrategy;
        }
    }
}
