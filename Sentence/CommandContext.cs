using System.Collections.Generic;

namespace Sentence
{
    public sealed class CommandContext : ICommandContext
    {
        private static CommandContext _commands;
        private Dictionary<string, ICommands> dictionary;

        private CommandContext()
        {
            dictionary = new Dictionary<string, ICommands>()
            {
                { "1", new Command1() },
                { "2", new Command2() }
            };
        }

        public static CommandContext GetCommands
        {
            get
            {
                if (_commands == null)
                {
                    _commands = new CommandContext();
                }

                return _commands;
            }
        }

        public ICommands GetCommand(string commandID)
        {
            return dictionary[commandID];
        }
    }
}
