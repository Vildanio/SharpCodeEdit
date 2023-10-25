using SharpEdit.VisualRendering;

namespace SharpEdit.CodeRendering
{
    public class IndexedVisualDocumentRenderer<TVisualDocument, TVisual>
        : VisualDocumentRenderer<TVisualDocument, TVisual>

        where TVisual : IVisual
        where TVisualDocument : IVisualDocument<TVisual>
    {
        public IndexedVisualDocumentRenderer(TVisualDocument visualDocument) : base(visualDocument)
        {
            
        }
    }
}
