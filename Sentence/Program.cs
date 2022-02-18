using System;

namespace Sentence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputString = string.Empty;
            string process = string.Empty;
            CommandContext cc = CommandContext.GetCommands;

            Console.WriteLine("Please enter a sentence / word :");
            inputString = Console.ReadLine();

            Console.WriteLine("Please choose your process :");
            Console.WriteLine("1 Reverse sentence.");
            Console.WriteLine("2 Reverse word.");

            process = Console.ReadLine();
            string result = cc.GetCommand(process).GetOutput(inputString);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
