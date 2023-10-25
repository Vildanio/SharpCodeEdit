using SharpEdit.LineText;

namespace SharpEdit.CodeEditing.Indentation
{
    public class RepeatIndentationStrategy : IIndenationStrategy
    {
        public int Indent(IReadOnlyLineText text, int index)
        {
            if(text.Count > 0)
            {
                return text[index - 1].GetIndent();
            }

            return 0;
        }
    }
}
