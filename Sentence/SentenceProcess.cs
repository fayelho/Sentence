using System;
namespace Sentence
{
    public class SentenceProcess : ISentenceProcess
    {
        public readonly CommandContext _context;

        public SentenceProcess()
        {
            _context = CommandContext.GetCommands;
        }

        public void Process()
        {
            string inputString = string.Empty;
            string process = string.Empty;

            Console.WriteLine("Please enter a sentence / word :");
            inputString = Console.ReadLine();

            Console.WriteLine("Please choose your process :");
            Console.WriteLine("1 Reverse sentence.");
            Console.WriteLine("2 Reverse word.");

            process = Console.ReadLine();

            string result = _context.GetCommand(process).GetOutput(inputString);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
