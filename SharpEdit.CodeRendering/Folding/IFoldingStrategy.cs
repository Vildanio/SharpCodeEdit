using SharpEdit.Text;
using SharpEdit.Utils;

namespace SharpEdit.CodeRendering.Folding
{
    public interface IFoldingStrategy
    {
        public IEnumerable<IntRange> GetFoldings(IReadOnlyText text, int start, int count);
    }
}
