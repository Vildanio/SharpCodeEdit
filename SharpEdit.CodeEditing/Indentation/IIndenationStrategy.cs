using SharpEdit.LineText;

namespace SharpEdit.CodeEditing.Indentation
{
    public interface IIndenationStrategy
    {
        public int Indent(IReadOnlyLineText text, int index);
    }
}
