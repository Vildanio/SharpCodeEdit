using System.Text.RegularExpressions;
using SharpEdit.Text;
using SharpEdit.Utils;

namespace SharpEdit.CodeRendering.Folding.RegexImpl
{
    public class RegexFoldingStrategy : IFoldingStrategy
    {
        public IEnumerable<Regex> Patterns { get; }

        public IEnumerable<IntRange> GetFoldings(IReadOnlyText text, int start, int count)
        {
            ReadOnlySpan<char> span = text.AsString(start, count);

            List<IntRange> foldings = new List<IntRange>();

            foreach (var pattern in Patterns)
            {
                foreach (var match in pattern.EnumerateMatches(span))
                {
                    IntRange folding = new IntRange(match.Index, match.Length);

                    foldings.Add(folding);
                }
            }

            return foldings;
        }

        public RegexFoldingStrategy(IEnumerable<Regex> patterns)
        {
            Patterns = patterns;
        }
    }
}
