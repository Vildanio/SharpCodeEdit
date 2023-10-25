using SharpEdit.CodeRendering.Highlighting;
using SharpEdit.LineText;
using SharpEdit.LineTextRendering;
using SharpEdit.VisualRendering;

namespace SharpEdit.CodeRendering.LineRenderers
{
    public class HighlightedLineTextRenderer<TLineDocument, TVisualTextDocument, TVisualText>

        : LineDocumentRenderer<TLineDocument, TVisualTextDocument, TVisualText>

        where TVisualText : IVisualText
        where TLineDocument : ILineDocument
        where TVisualTextDocument : IVisualDocument<TVisualText>
    {
        public IHighlightingStrategy? HighlightingStrategy
        {
            get
            {
                if (VisualTextProvider is HighlightedTextProvider highlightedTextProvider)
                {
                    return highlightedTextProvider.HighlightingStrategy;
                }

                return null;
            }
        }

        #region Constructors

        protected HighlightedLineTextRenderer(
            VisualDocumentRenderer<TVisualTextDocument, TVisualText> renderer,
            IVisualLineGroupProvider<TVisualTextDocument, TVisualText> visualTextProvider,
            TLineDocument document)

            : base(renderer, visualTextProvider, document)
        {
        }

        protected HighlightedLineTextRenderer(
            VisualDocumentRenderer<TVisualTextDocument, TVisualText> renderer,
            IVisualLineGroupProvider<TVisualTextDocument, TVisualText> visualTextProvider,
            ILineCaret caret, ILineSelection selection, TLineDocument document)

            : base(renderer, visualTextProvider, caret, selection, document)
        {
        }

        #endregion
    }
}
