namespace Sentence
{
    public interface ICommandContext
    {
        public ICommands GetCommand(string commandID);
    }
}
