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

            do
            {
                Console.WriteLine("Please enter a sentence / word :");
                inputString = Console.ReadLine();

            } while (string.IsNullOrEmpty(inputString) || string.IsNullOrWhiteSpace(inputString));

            do
            {
                Console.WriteLine("Please choose your process :");
                Console.WriteLine("1 Reverse sentence.");
                Console.WriteLine("2 Reverse word.");

                process = Console.ReadLine();

            } while (process != "1" && process != "2");

            string result = _context.GetCommand(process).GetOutput(inputString);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
