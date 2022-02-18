using System;
using System.Collections.Generic;
using System.Linq;

namespace Sentence
{
    public class Command1 : Commands
    {
        public Command1()
        {
        }

        public override string GetOutput(string input)
        {
            try
            {
                string result = string.Empty;

                if (string.IsNullOrWhiteSpace(input))
                {
                    return "please introduce a correct sentence";
                }
                else
                {
                    List<string> words = new List<string>();
                    words = input.Split(' ').ToList();

                    words.Reverse();
                    result = words.First();
                    words.Remove(words.First());

                    foreach (string word in words)
                        result += $" {word}";
                }
                
                return result;
            }

            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
