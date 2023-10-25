using SharpEdit.CodeEditing.Indentation;
using SharpEdit.CodeRendering.Folding;
using SharpEdit.CodeRendering.Highlighting;

namespace SharpEdit.CodeEditing
{
    public interface ILanguage
    {
        public string Name { get; }

        public IFoldingStrategy FoldingStrategy { get; }

        public IIndenationStrategy IndenationStrategy { get; }

        public IHighlightingStrategy HighlightingStrategy { get; }
    }
}
