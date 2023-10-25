namespace SharpEdit.CodeEditing.Completion
{
    public interface ICompletionProvider
    {
        public IEnumerable<string> GetCompletions(string text);
    }
}
