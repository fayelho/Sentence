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

                char[] chars = input.ToCharArray();
                Array.Reverse(chars);
                result = string.Join("", chars);
                
                return result;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
