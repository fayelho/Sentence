using System;
using System.Collections.Generic;

namespace Sentence
{
    public class Command2 : Commands
    {
        public Command2()
        {
        }

        public override string GetOutput(string input)
        {
            try
            {
                string result = string.Empty;

                if (string.IsNullOrEmpty(input))
                {
                    return "Please enter a word";
                }

                else
                {
                    List<char> chars = new List<char>();
                    foreach (char c in input)
                        chars.Add(c);

                    chars.Reverse();
                    foreach (char c in chars)
                        result += c;

                    return result;
                }
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
