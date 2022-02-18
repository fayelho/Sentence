namespace Sentence
{
    public abstract class Commands : ICommands
    {
        public abstract string GetOutput(string input);
    }
}
